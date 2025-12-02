using OOP_Basics;

class Program
{
    static void Main()
    {
        Linear eq1 = new Linear(2, -3);
        eq1.PrintEquation();
        Console.WriteLine($"eq1 при x=1: {eq1.Calculate(1)}");

        Linear eq2 = new Linear(0, 5);
        eq2.PrintEquation();
        Console.WriteLine($"eq2 при x=10: {eq2.Calculate(10)}");

        Linear eq3 = new Linear(-1, 0);
        eq3.PrintEquation();
        Console.WriteLine($"eq3 при x=2: {eq3.Calculate(2)}");

        Linear eq4 = new Linear(-3, 4);
        eq4.PrintEquation();       
        eq4.A = 2;
        eq4.B = 0;
        eq4.PrintEquation();        
        Console.WriteLine($"eq4 при x=10: {eq4.Calculate(10)}"); 


        try 
        {
            eq3.A = double.NaN;
        }

        catch (System.ArgumentException ex)
        {
            System.Console.WriteLine("Ошибка: " + ex.Message);
        }


    }
}
