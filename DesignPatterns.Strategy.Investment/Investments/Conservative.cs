namespace DesignPatterns.Strategy.Investment
{
    public class Conservative : IInvestment
    {
        public double Calculate(Account account)
        {
            return account.balance * 0.08;
        }
    }
}
