using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Investment
{
    public class Account
    {
        public double balance;

        public void Deposit(double balance)
        {
            this.balance += balance;
        }
    }
}
