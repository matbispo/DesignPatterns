using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ICCC : ITax
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value < 1000)           
                return budget.Value * 0.05;            
            else if (budget.Value < 3000)
                return budget.Value * 0.07;
            else
                return budget.Value * 0.08 + 30;   
        }
    }
}
