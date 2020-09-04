using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy.Investment
{
    public interface IInvestment
    {
        double Calculate(Account account);
    }
}
