using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_COLLECTIONS
{
    public class Beans : Product
    {
        public Beans(string name, double price, double weight)
            : base(name, price, weight, true) { }

        public override double GetDiscount()
        {
            if (WeightKg > 2)
                return PricePerKg * WeightKg * 0.05; 
            return 0;
        }
    }
}
