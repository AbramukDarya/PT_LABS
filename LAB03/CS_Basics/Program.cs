using System;

namespace ConsoleAppTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Меню задач ===");
                Console.WriteLine("1. Блок 1: Переменные и операторы");
                Console.WriteLine("2. Блок 2: Условные операторы");
                Console.WriteLine("3. Блок 3: Циклы");
                Console.WriteLine("4. Блок 4: Массивы");
                Console.WriteLine("5. Блок 5: Функции");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите блок задач (0-5): ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Некорректный ввод. Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Block1();
                        break;
                    case 2:
                        Block2();
                        break;
                    case 3:
                        Block3();
                        break;
                    case 4:
                        Block4();
                        break;
                    case 5:
                        Block5();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void Block1()
        {
            Console.Clear();
            Console.WriteLine("=== Блок 1: Переменные и операторы ===");
            Console.WriteLine("1. Конвертация температуры");
            Console.WriteLine("2. Конвертация валюты");
            Console.WriteLine("3. Среднее арифметическое трёх чисел");
            Console.Write("Выберите задачу: ");
            if (!int.TryParse(Console.ReadLine(), out int task)) return;

            switch (task)
            {
                case 1:
                    Console.Write("Введите температуру в °C: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius))
                    {
                        double fahrenheit = celsius * 9.0 / 5.0 + 32;
                        Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
                    }
                    break;
                case 2:
                    const double USD_RATE = 3.25;
                    Console.Write("Введите сумму в BYN: ");
                    if (double.TryParse(Console.ReadLine(), out double byn))
                    {
                        double usd = byn / USD_RATE;
                        Console.WriteLine($"{byn} BYN = {usd:F2} USD (курс: {USD_RATE})");
                    }
                    break;
                case 3:
                    Console.Write("Введите первое число: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    double c = double.Parse(Console.ReadLine());
                    double avg = (a + b + c) / 3.0;
                    Console.WriteLine($"Среднее арифметическое: {avg:F2}");
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Block2()
        {
            Console.Clear();
            Console.WriteLine("=== Блок 2: Условные операторы ===");
            Console.WriteLine("1. Время года по номеру месяца");
            Console.WriteLine("2. Координатная четверть");
            Console.WriteLine("3. Время суток по часам");
            Console.Write("Выберите задачу: ");
            if (!int.TryParse(Console.ReadLine(), out int task)) return;

            switch (task)
            {
                case 1:
                    Console.Write("Введите номер месяца (1-12): ");
                    if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
                    {
                        string season = month switch
                        {
                            12 or 1 or 2 => "Зима",
                            3 or 4 or 5 => "Весна",
                            6 or 7 or 8 => "Лето",
                            9 or 10 or 11 => "Осень",
                            _ => "Неизвестно"
                        };
                        Console.WriteLine($"Месяц {month} — {season}");
                    }
                    else
                        Console.WriteLine("Неверный номер месяца!");
                    break;
                case 2:
                    Console.Write("Введите X: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите Y: ");
                    double y = double.Parse(Console.ReadLine());

                    if (x == 0 || y == 0)
                        Console.WriteLine("Точка лежит на оси координат.");
                    else if (x > 0 && y > 0)
                        Console.WriteLine("Точка в 1 четверти.");
                    else if (x < 0 && y > 0)
                        Console.WriteLine("Точка во 2 четверти.");
                    else if (x < 0 && y < 0)
                        Console.WriteLine("Точка в 3 четверти.");
                    else
                        Console.WriteLine("Точка в 4 четверти.");
                    break;
                case 3:
                    Console.Write("Введите час (0-23): ");
                    if (int.TryParse(Console.ReadLine(), out int hour) && hour >= 0 && hour <= 23)
                    {
                        string timeOfDay = hour switch
                        {
                            >= 6 and < 12 => "Утро",
                            >= 12 and < 18 => "День",
                            >= 18 and < 24 => "Вечер",
                            _ => "Ночь"
                        };
                        Console.WriteLine($"Час {hour} — {timeOfDay}");
                    }
                    else
                        Console.WriteLine("Неверный формат часа");
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Block3()
        {
            Console.Clear();
            Console.WriteLine("=== Блок 3: Циклы ===");
            Console.WriteLine("1. Минимальная и максимальная цифра числа");
            Console.WriteLine("2. Числа Фибоначчи");
            Console.WriteLine("3. Среднее арифметическое N чисел");
            Console.Write("Выберите задачу: ");
            if (!int.TryParse(Console.ReadLine(), out int task)) return;

            switch (task)
            {
                case 1:
                    Console.Write("Введите целое число: ");
                    string numStr = Console.ReadLine();
                    if (long.TryParse(numStr, out long num))
                    {
                        num = Math.Abs(num);
                        int min = 9, max = 0;
                        if (num == 0) min = max = 0;
                        while (num > 0)
                        {
                            int digit = (int)(num % 10);
                            if (digit < min) min = digit;
                            if (digit > max) max = digit;
                            num /= 10;
                        }
                        Console.WriteLine($"Минимальная цифра: {min}, максимальная: {max}");
                    }
                    break;
                case 2:
                    Console.Write("Сколько чисел Фибоначчи вывести? ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        long a = 0, b = 1;
                        Console.Write("Числа Фибоначчи: ");
                        for (int i = 0; i < n; i++)
                        {
                            if (i == 0)
                                Console.Write(a + " ");
                            else if (i == 1)
                                Console.Write(b + " ");
                            else
                            {
                                long next = a + b;
                                Console.Write(next + " ");
                                a = b;
                                b = next;
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.Write("Сколько чисел вводить? ");
                    if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
                    {
                        double sum = 0;
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"Введите число {i + 1}: ");
                            sum += double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"Среднее арифметическое: {sum / count:F2}");
                    }
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Block4()
        {
            Console.Clear();
            Console.WriteLine("=== Блок 4: Массивы ===");
            Console.WriteLine("1. Суммы строк и столбцов");
            Console.WriteLine("2. Обратный порядок");
            Console.WriteLine("3. Разделение на положительные и отрицательные");
            Console.Write("Выберите задачу: ");
            if (!int.TryParse(Console.ReadLine(), out int task)) return;

            Random rand = new Random();

            switch (task)
            {
                case 1:
                    Console.Write("Введите количество строк: ");
                    int rows = int.Parse(Console.ReadLine());
                    Console.Write("Введите количество столбцов: ");
                    int cols = int.Parse(Console.ReadLine());

                    int[,] matrix = new int[rows, cols];
                    for (int i = 0; i < rows; i++)
                        for (int j = 0; j < cols; j++)
                            matrix[i, j] = rand.Next(1, 101);


                    int[] rowSums = new int[rows];
                    for (int i = 0; i < rows; i++)
                        for (int j = 0; j < cols; j++)
                            rowSums[i] += matrix[i, j];


                    int[] colSums = new int[cols];
                    for (int j = 0; j < cols; j++)
                        for (int i = 0; i < rows; i++)
                            colSums[j] += matrix[i, j];


                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                            Console.Write(matrix[i, j].ToString().PadLeft(4));
                        Console.WriteLine(" | Сумма: " + rowSums[i]);
                    }

                    Console.WriteLine(new string('-', cols * 4 + 10));
                    for (int j = 0; j < cols; j++)
                        Console.Write(colSums[j].ToString().PadLeft(4));
                    Console.WriteLine();


                    int minRow = 0, maxRow = 0, minCol = 0, maxCol = 0;
                    for (int i = 1; i < rows; i++)
                    {
                        if (rowSums[i] < rowSums[minRow]) minRow = i;
                        if (rowSums[i] > rowSums[maxRow]) maxRow = i;
                    }
                    for (int j = 1; j < cols; j++)
                    {
                        if (colSums[j] < colSums[minCol]) minCol = j;
                        if (colSums[j] > colSums[maxCol]) maxCol = j;
                    }

                    Console.WriteLine($"Строка с мин. суммой: {minRow + 1} ({rowSums[minRow]})");
                    Console.WriteLine($"Строка с макс. суммой: {maxRow + 1} ({rowSums[maxRow]})");
                    Console.WriteLine($"Столбец с мин. суммой: {minCol + 1} ({colSums[minCol]})");
                    Console.WriteLine($"Столбец с макс. суммой: {maxCol + 1} ({colSums[maxCol]})");
                    break;

                case 2:
                    Console.Write("Размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    for (int i = 0; i < size; i++)
                        arr[i] = rand.Next(1, 101);

                    Console.WriteLine("Исходный массив: " + string.Join(", ", arr));


                    for (int i = 0; i < size / 2; i++)
                    {
                        int temp = arr[i];
                        arr[i] = arr[size - 1 - i];
                        arr[size - 1 - i] = temp;
                    }

                    Console.WriteLine("Массив в обратном порядке: " + string.Join(", ", arr));
                    break;

                case 3:
                    Console.Write("Размер массива: ");
                    int n = int.Parse(Console.ReadLine());
                    int[] nums = new int[n];
                    for (int i = 0; i < n; i++)
                        nums[i] = rand.Next(-100, 101);

                    Console.WriteLine("Исходный массив: " + string.Join(", ", nums));


                    int posCount = 0, negCount = 0;
                    foreach (int x in nums)
                    {
                        if (x > 0) posCount++;
                        else if (x < 0) negCount++;
                    }

                    int[] positives = new int[posCount];
                    int[] negatives = new int[negCount];
                    int pIndex = 0, nIndex = 0;

                    foreach (int x in nums)
                    {
                        if (x > 0) positives[pIndex++] = x;
                        else if (x < 0) negatives[nIndex++] = x;
                    }

                    Console.WriteLine("Положительные: " + (posCount > 0 ? string.Join(", ", positives) : "нет"));
                    Console.WriteLine("Отрицательные: " + (negCount > 0 ? string.Join(", ", negatives) : "нет"));
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Block5()
        {
            Console.Clear();
            Console.WriteLine("=== Блок 5: Функции ===");
            Console.WriteLine("1. Факториал");
            Console.WriteLine("2. Сумма массива");
            Console.WriteLine("3. Деление с остатком");
            Console.WriteLine("4. Фильтрация чётных чисел");
            Console.Write("Выберите задачу: ");
            if (!int.TryParse(Console.ReadLine(), out int task)) return;

            switch (task)
            {
                case 1:
                    Console.Write("Введите число для факториала: ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                    {
                        long fact = Factorial(n);
                        Console.WriteLine($"{n}! = {fact}");
                    }
                    else
                        Console.WriteLine("Факториал определён только для n >= 0");
                    break;
                case 2:
                    int[] arr = { 1, 2, 3, 4, 5 };
                    Console.WriteLine("Массив: [1, 2, 3, 4, 5]");
                    Console.WriteLine("Сумма: " + Sum(arr, 0));
                    break;
                case 3:
                    Console.Write("Делимое: ");
                    int dividend = int.Parse(Console.ReadLine());
                    Console.Write("Делитель: ");
                    int divisor = int.Parse(Console.ReadLine());
                    if (divisor != 0)
                    {
                        Divide(dividend, divisor, out int quotient, out int remainder);
                        Console.WriteLine($"{dividend} / {divisor} = {quotient}, остаток {remainder}");
                    }
                    else
                        Console.WriteLine("Делить на ноль нельзя");
                    break;
                case 4:
                    int[] evens = FilterEven(2, 4, 5, 6, 8, 13, 10);
                    Console.WriteLine("Чётные из (2,4,5,6,8,13,10): " + string.Join(", ", evens));
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static long Factorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Факториал не определён для отрицательных чисел.");
                return -1; 
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        static int Sum(int[] array, int index)
        {
            if (index >= array.Length) return 0;
            return array[index] + Sum(array, index + 1);
        }

        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        static int[] FilterEven(params int[] numbers)
        {
            int count = 0;
            foreach (int num in numbers)
                if (num % 2 == 0) count++;

            int[] result = new int[count];
            int idx = 0;
            foreach (int num in numbers)
                if (num % 2 == 0)
                    result[idx++] = num;

            return result;
        }
    }
}
    

