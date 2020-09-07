using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsability
{
    public interface IDiscount
    {
        IDiscount Next { get; set; }
        void Calculate(Cart cart);
    }
}
