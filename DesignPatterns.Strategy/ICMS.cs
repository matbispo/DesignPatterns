
namespace DesignPatterns.Strategy
{
    public class ICMS : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.01;
        }
    }
}
