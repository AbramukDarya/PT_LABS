using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_COLLECTIONS
{
    public class Meat : Product
    {
        public Meat(string name, double price, double weight)
            : base(name, price, weight, false) { }

        public override double GetDiscount()
        {
            return PricePerKg * WeightKg * 0.1; 
        }
    }
}
