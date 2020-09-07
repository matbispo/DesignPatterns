
using System.ComponentModel;

namespace DesignPatterns.ChainOfResponsability.Discounts
{
    public class WithoutDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public void Calculate(Cart cart)
        {
            return;
        }
    }
}
