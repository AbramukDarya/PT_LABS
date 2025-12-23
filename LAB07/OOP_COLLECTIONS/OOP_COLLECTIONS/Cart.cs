using OOP_COLLECTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_COLLECTIONS
{
    public class Cart
    {
        private int maxAmount;

        public int MaxAmount
        {
            get { return maxAmount; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Максимальное количество товаров должно быть >= 1.");
                maxAmount = value;
            }
        }

        private List<Product> products = new List<Product>();

        public Cart(int maxAmount)
        {
            MaxAmount = maxAmount; 
        }

        public void AddToCart(Product p)
        {
            if (p == null)
            {
                Console.WriteLine("Нельзя добавить пустой товар.");
                return;
            }

            if (products.Count >= MaxAmount)
            {
                Console.WriteLine("Корзина полная! Нельзя добавить ещё товар.");
                return;
            }

            products.Add(p);
        }

        public void DeleteFromCart(Product p)
        {
            if (p == null || !products.Contains(p))
            {
                Console.WriteLine("Товар не найден в корзине.");
                return;
            }
            products.Remove(p);
        }

        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (var p in products)
                total += p.PricePerKg * p.WeightKg;
            return total;
        }

        public double CalculateDiscountedCost()
        {
            double total = 0;
            foreach (var p in products)
                total += p.PricePerKg * p.WeightKg - p.GetDiscount();
            return total;
        }

        public double CalculateAvgVegetarianCost()
        {
            double total = 0;
            int count = 0;
            foreach (var p in products)
            {
                if (p.IsVegetarian)
                {
                    total += p.PricePerKg * p.WeightKg;
                    count++;
                }
            }
            return count == 0 ? 0 : total / count;
        }

        public static bool operator ==(Cart a, Cart b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return Math.Abs(a.CalculateDiscountedCost() - b.CalculateDiscountedCost()) < 0.01;
        }

        public static bool operator !=(Cart a, Cart b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj) => this == (obj as Cart);
    }
}
