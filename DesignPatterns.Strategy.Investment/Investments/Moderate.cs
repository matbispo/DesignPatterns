using System;

namespace DesignPatterns.Strategy.Investment
{
    public class Moderate : IInvestment
    {
        public double Calculate(Account account)
        {
            if (new Random().Next(101) > 50)
                return account.balance * 0.025;
            else
                return account.balance * 0.07;           
        }
    }
}
