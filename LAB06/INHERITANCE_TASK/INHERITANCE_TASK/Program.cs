using INHERITANCE_TASK;
using INHERITANCE_TASK.OOP_INHERITANCE;
class Program
{
        static void Main()
        {
            Function[] functions = new Function[10]
            {
                new LinearFunction(-1, 4, 3, -2),        
                new LinearFunction(0, 6, -0.5, 5),      
                new LogarithmicFunction(0.5, 5, 2.5),   
                new LogarithmicFunction(1, 8, 1.2),     
                new PowerFunction(-2, 4, 1.5, 3),       
                new PowerFunction(0, 5, 3, 0.5),        
                new TrigonometricFunction(-5, 5, "sin"), 
                new TrigonometricFunction(0, Math.PI, "cos"), 
                new LinearFunction(-3, 3, 1, 0),        
                new PowerFunction(1, 10, 0.8, 2)        
            };


            Console.WriteLine("1. Среднее значение при x = 2:\n");

            double sumAt2 = 0.0;
            int countValidAt2 = 0;

            foreach (Function func in functions)
            {
                try
                {
                    double value = func.GetValue(2);
                    Console.WriteLine($"  {func.FunctionName,-25} | f(2) = {Math.Round(value, 6)}");
                    sumAt2 += value;
                    countValidAt2++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  {func.FunctionName,-25} | f(2) = недоступно ({ex.Message})");
                }
            }

            if (countValidAt2 > 0)
            {
                double averageAt2 = sumAt2 / countValidAt2;
                Console.WriteLine($"\n  Среднее: {Math.Round(averageAt2, 6)} (учтено {countValidAt2} функций)\n");
            }

            Console.WriteLine("2. Функция с максимальным значением при x = 1:\n");

            double maxAt1 = double.MinValue;
            Function bestFuncAt1 = null;

            foreach (Function func in functions)
            {
                try
                {
                    double value = func.GetValue(1);
                    Console.WriteLine($"  {func.FunctionName,-25} | f(1) = {Math.Round(value, 6)}");

                    if (value > maxAt1)
                    {
                        maxAt1 = value;
                        bestFuncAt1 = func;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  {func.FunctionName,-25} | f(1) = недоступно ({ex.Message})");
                }
            }

            if (bestFuncAt1 != null)
            {
                Console.WriteLine($"\n  Максимум: {bestFuncAt1.FunctionName} → f(1) = {Math.Round(maxAt1, 6)}\n");
            }

            Console.WriteLine("3. Представление всех функций:\n");

            foreach (Function func in functions)
            {
                Console.WriteLine(func.ToString());
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
}