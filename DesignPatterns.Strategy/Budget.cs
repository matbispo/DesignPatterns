
using System;
using System.Dynamic;

namespace DesignPatterns.Strategy
{
    public class Budget
    {
        public double Value { get; private set; }

        public Budget( double value)
        {
            setValue(value);
        }

        public void setValue(double value)
        {
            if (value > 0)
                this.Value = value;
            else
                throw new Exception("Invalid value");
        }
    }
}
