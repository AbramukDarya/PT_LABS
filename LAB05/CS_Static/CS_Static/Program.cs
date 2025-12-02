using CS_Static;

class Program
{
    static void Main()
    {
        Box b1 = new Box(10, 8, 6);
        Box b2 = new Box(7, 5, 4);

        Console.WriteLine("Исходные коробки:");
        Console.WriteLine(b1);
        Console.WriteLine(b2);

        Box b3 = b1 + b2; 
        Box b4 = b1 - b2; 


        Console.WriteLine($"b1 + b2 = {b3}");
        Console.WriteLine($"b1 - b2 = {b4}");

        Console.WriteLine($"b1 и b2 одинаковые по объёму: {b1.Equals(b2)}");

    }
}
