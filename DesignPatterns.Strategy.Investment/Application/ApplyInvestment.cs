

namespace DesignPatterns.Strategy.Investment
{
    public class Investment
    {
        public void ApplyInvestment(Account account, IInvestment investment)
        {
            double balance = investment.Calculate(account);
            account.Deposit(balance * 0.75);
        }
    }
}
