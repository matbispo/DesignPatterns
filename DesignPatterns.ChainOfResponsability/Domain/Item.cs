using System;

namespace DesignPatterns.ChainOfResponsability
{
    public class Item
    {
        public string Description { get; private set; }
        public double Value { get; private set; }

        public Item(string decription, double value)
        {
            if (string.IsNullOrWhiteSpace(decription) && !(value > 0))
            {
                throw new NotImplementedException();
            }

            this.Description = Description;
            this.Value = value;
        }
    }
}
