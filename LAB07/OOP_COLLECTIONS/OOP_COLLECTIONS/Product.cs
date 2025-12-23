using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_COLLECTIONS
{
    public class Product : IDiscountable
    {
        public string Name;
        public double PricePerKg;
        public double WeightKg;
        public bool IsVegetarian;

        public Product(string name, double price, double weight, bool isVegetarian)
        {
            Name = name;
            PricePerKg = price;
            WeightKg = weight;
            IsVegetarian = isVegetarian;
        }

        public override string ToString()
        {
            return $"{Name} — {WeightKg} кг по {PricePerKg} р.";
        }

        public virtual double GetDiscount()
        {
            return 0; 
        }
    }
}
