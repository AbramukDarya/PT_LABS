using OOP_COLLECTIONS;

using System;

class Program
{
    static void Main()
    {
        var cart1 = new Cart(5);
        var cart2 = new Cart(4);

        cart1.AddToCart(new Meat("Говядина", 500, 1.0));
        cart1.AddToCart(new Apple("Яблоки", 100, 2.0, "зелёные"));
        cart1.AddToCart(new Beans("Чечевица", 150, 3.0));
        cart1.AddToCart(new Apple("Яблоки", 120, 1.0, "красные"));
        cart1.AddToCart(new Beans("Фасоль белая", 160, 2.5));

        cart2.AddToCart(new Meat("Свинина", 450, 1.5));
        cart2.AddToCart(new Apple("Яблоки", 100, 2.5, "зелёные"));
        cart2.AddToCart(new Beans("Фасоль", 140, 3.5));
        cart2.AddToCart(new Meat("Курица", 300, 2.0));
        cart2.AddToCart(new Apple("Яблоки", 120, 1.2, "красные"));


        Console.WriteLine("=== Корзина 1 ===");
        Console.WriteLine("Общая стоимость: " + cart1.CalculateTotalCost().ToString("F2"));
        Console.WriteLine("Со скидкой: " + cart1.CalculateDiscountedCost().ToString("F2"));
        Console.WriteLine("Средняя стоимость вегетарианских товаров: " + cart1.CalculateAvgVegetarianCost().ToString("F2"));


        Console.WriteLine("\n=== Корзина 2 ===");
        Console.WriteLine("Общая стоимость: " + cart2.CalculateTotalCost().ToString("F2"));
        Console.WriteLine("Со скидкой: " + cart2.CalculateDiscountedCost().ToString("F2"));
        Console.WriteLine("Средняя стоимость вегетарианских товаров: " + cart2.CalculateAvgVegetarianCost().ToString("F2"));

 
        Console.WriteLine("\nКорзины равны по стоимости со скидкой? " + (cart1 == cart2));
    }
}