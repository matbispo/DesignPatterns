using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsability
{
    public class Cart
    {
        public ICollection<Item> Items { get; private set; }

        public double Total { get; set; }
        public double Discount { get; set; }
        public void AddItem(Item item)
        {
            Items.Add(item);
            Total += item.Value;
        }

        public Cart()
        {
            Items = new List<Item>();
            Total = 0.0;
            Discount = 0.0;
        }
    }
}
