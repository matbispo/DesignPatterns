using System;

namespace DesignPatterns.Strategy.Investment
{
    public class Risky : IInvestment
    {
        public double Calculate(Account account)
        {
            if (new Random().Next(101) > 80)
                return account.balance * 0.05;
            else if (new Random().Next(101) > 70)
                return account.balance * 0.03;
            else if (new Random().Next(101) > 50)
                return account.balance * 0.06;
            else
                return account.balance;
        }
    }
}
