using System;

namespace DesignPatterns.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsability");

            Cart cart = new Cart();
            cart.AddItem(new Item("TV", 500));
            cart.AddItem(new Item ("PC",  5000));
            cart.AddItem(new Item ("Phone", 800));
            cart.AddItem(new Item ("Monitor", 600));
            cart.AddItem(new Item ("Mouse", 200));

            CalculateDiscount calculateDiscount = new CalculateDiscount();

            calculateDiscount.Calculate(cart);

            Console.WriteLine(cart.Discount.ToString());

            Console.ReadKey();
        }
    }
}
