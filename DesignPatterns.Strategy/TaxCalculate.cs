
namespace DesignPatterns.Strategy
{
    public class TaxCalculate
    {
        public double Calculate(Budget budget, ITax tax)
        {
            return tax.Calculate(budget);
        }
    }
}
