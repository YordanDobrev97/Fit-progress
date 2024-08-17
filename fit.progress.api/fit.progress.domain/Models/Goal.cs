namespace fit.progress.domain.Models
{
    using fit.progress.domain.Exceptions;
    using fit.progress.domain.Shared;

    internal class Goal : Entity<int>
    {
        private string name;
        private int targetWeight;
        private ProgressTracking progressTracking;
        private int age;

        public Goal(string name) {
            this.Name = name;
        }

        public double TargetWeight => this.targetWeight;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Goal name cannot be empty or whitespace!", nameof(value));
                }

                this.name = value;
            }
        }

        public void UpdateTargetWeight(User user, int targetWeight)
        {
            if (!this.IsTargetWeightHealty(user, targetWeight))
            {
                throw new InvalidTargetWeightException("The specified target weight is not considered healthy based on your height, weight, and other personal metrics!");
            }

            this.targetWeight = targetWeight;
        }

        private bool IsTargetWeightHealty(User user, int targetWeight)
        {
            return true;
        }
    }
}
