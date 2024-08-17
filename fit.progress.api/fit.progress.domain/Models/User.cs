namespace fit.progress.domain.Models
{
    using fit.progress.domain.Shared;

    internal class User : Entity<int>, IAggregateRoot
    {
        private string name;
        private double height;
        private double weight;
        private Gender gender;
        private Goal Goal;

        public User(string name, double height, double weight, Gender gender)
        {
            this.Name = name;
            this.gender = gender;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace!", nameof(value));    
                }

                this.name = value;
            }
        }

        public Gender Gender
        {
            get => this.gender;
            private set => this.gender = value;
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value < Constants.MIN_USER_HEIGHT_VALUE)
                {
                    throw new ArgumentException($"The minimum height value is ${Constants.MIN_USER_HEIGHT_VALUE}!");
                }
                this.height = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set => this.weight = value;
        }
    }
}
