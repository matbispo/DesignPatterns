
namespace DesignPatterns.ChainOfResponsability
{
    public class OverTwoThosand : IDiscount
    {
        public IDiscount Next { get; set; }

        public void Calculate(Cart cart)
        {
            if (cart.Total > 2000)
            {
                cart.Discount +=  cart.Total * 0.07;
            }
            Next.Calculate(cart);
        }
    }
}
