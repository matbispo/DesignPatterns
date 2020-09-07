using DesignPatterns.ChainOfResponsability.Discounts;
using System;

namespace DesignPatterns.ChainOfResponsability
{
    public class CalculateDiscount
    {
        public void Calculate(Cart cart)
        {
            IDiscount d1 = new ByFiveItens();
            IDiscount d2 = new OverTwoThosand();
            IDiscount without = new  WithoutDiscount();

            d1.Next = d2;
            d2.Next = without;

            d1.Calculate(cart);
        }
    }  
}
