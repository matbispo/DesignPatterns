
namespace DesignPatterns.ChainOfResponsability
{
    public class ByFiveItens : IDiscount
    {
        public IDiscount Next { get; set; }
        public void Calculate(Cart cart)
        {
            if (cart.Items.Count >= 5)
            {
                cart.Discount += cart.Total * 0.05;
            }

            Next.Calculate(cart);  
        }
    }
}