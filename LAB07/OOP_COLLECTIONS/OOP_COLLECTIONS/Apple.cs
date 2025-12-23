using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_COLLECTIONS
{
    public class Apple : Product
    {
        public string Color;

        public Apple(string name, double price, double weight, string color)
            : base(name, price, weight, true)
        {
            Color = color;
        }

        public override double GetDiscount()
        {
            if (Color == "зелёные")
                return PricePerKg * WeightKg * 0.15; 
            return 0;
        }
    }
}
