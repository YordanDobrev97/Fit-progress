namespace fit.progress.domain.Models
{
    internal interface IWeightHealthCalculator
    {
        bool IsHealthy(User user, double targetWeight);
    }
}
