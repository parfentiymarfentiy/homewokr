//using System;

//class Program
//{
//    static void Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("МЕНЮ");
//            Console.WriteLine("1. FizzBuzz");
//            Console.WriteLine("2. Відсоток від числа");
//            Console.WriteLine("3. Число з чотирьох цифр");
//            Console.WriteLine("4. Обмін цифр у шестизначному числі");
//            Console.WriteLine("5. Визначення сезону та дня тижня");
//            Console.WriteLine("6. Конвертер температури");
//            Console.WriteLine("7. Парні числа в діапазоні");
//            Console.WriteLine("8. Число Армстронга");
//            Console.WriteLine("9. Досконале число");
//            Console.WriteLine("0. Вихід");
//            Console.Write("Вибір: ");
//            string choice = Console.ReadLine();

//            Console.Clear();

//            switch (choice)
//            {
//                case "1":
//                    Task1();
//                    break;
//                case "2":
//                    Task2();
//                    break;
//                case "3":
//                    Task3();
//                    break;
//                case "4":
//                    Task4();
//                    break;
//                case "5":
//                    Task5();
//                    break;
//                case "6":
//                    Task6();
//                    break;
//                case "7":
//                    Task7();
//                    break;
//                case "8":
//                    Task8();
//                    break;
//                case "9":
//                    Task9();
//                    break;
//                case "0":
//                    return;
//            }

//            Console.WriteLine("\nНатисніть будь-яку клавішу...");
//            Console.ReadKey();
//        }
//    }

//    static void Task1()
//    {
//        Console.Write("Введіть число від 1 до 100: ");
//        if (int.TryParse(Console.ReadLine(), out int num))
//        {
//            if (num < 1 || num > 100)
//            {
//                Console.WriteLine("Помилка");
//            }
//            else if (num % 3 == 0 && num % 5 == 0)
//            {
//                Console.WriteLine("Fizz Buzz");
//            }
//            else if (num % 3 == 0)
//            {
//                Console.WriteLine("Fizz");
//            }
//            else if (num % 5 == 0)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else
//            {
//                Console.WriteLine(num);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Помилка");
//        }
//    }

//    static void Task2()
//    {
//        Console.Write("Введіть число: ");
//        double number = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Введіть відсоток: ");
//        double percent = Convert.ToDouble(Console.ReadLine());
//        double result = (number * percent) / 100;
//        Console.WriteLine($"Результат: {result}");
//    }

//    static void Task3()
//    {
//        Console.WriteLine("Введіть чотири цифри:");
//        string numberStr = "";
//        for (int i = 1; i <= 4; i++)
//        {
//            Console.Write($"Цифра {i}: ");
//            numberStr += Console.ReadLine();
//        }
//        Console.WriteLine($"Число: {numberStr}");
//    }

//    static void Task4()
//    {
//        Console.Write("Введіть шестизначне число: ");
//        string number = Console.ReadLine();

//        if (number.Length != 6 || !int.TryParse(number, out _))
//        {
//            Console.WriteLine("Помилка");
//            return;
//        }

//        Console.Write("Введіть перший розряд (1-6): ");
//        int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
//        Console.Write("Введіть другий розряд (1-6): ");
//        int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

//        if (pos1 < 0 || pos1 > 5 || pos2 < 0 || pos2 > 5)
//        {
//            Console.WriteLine("Помилка");
//            return;
//        }

//        char[] digits = number.ToCharArray();
//        char temp = digits[pos1];
//        digits[pos1] = digits[pos2];
//        digits[pos2] = temp;

//        Console.WriteLine($"Результат: {new string(digits)}");
//    }

//    static void Task5()
//    {
//        Console.Write("Введіть дату (дд.мм.рррр): ");
//        string dateStr = Console.ReadLine();

//        if (DateTime.TryParse(dateStr, out DateTime date))
//        {
//            string season = "";
//            int month = date.Month;

//            if (month == 12 || month <= 2) season = "Winter";
//            else if (month >= 3 && month <= 5) season = "Spring";
//            else if (month >= 6 && month <= 8) season = "Summer";
//            else season = "Autumn";

//            string day = date.DayOfWeek.ToString();

//            Console.WriteLine($"{season} {day}");
//        }
//        else
//        {
//            Console.WriteLine("Помилка");
//        }
//    }

//    static void Task6()
//    {
//        Console.WriteLine("1. Цельсій → Фаренгейт");
//        Console.WriteLine("2. Фаренгейт → Цельсій");
//        Console.Write("Вибір: ");
//        string choice = Console.ReadLine();

//        Console.Write("Введіть температуру: ");
//        double temp = Convert.ToDouble(Console.ReadLine());

//        if (choice == "1")
//        {
//            double f = (temp * 9 / 5) + 32;
//            Console.WriteLine($"{temp}°C = {f}°F");
//        }
//        else if (choice == "2")
//        {
//            double c = (temp - 32) * 5 / 9;
//            Console.WriteLine($"{temp}°F = {c}°C");
//        }
//    }

//    static void Task7()
//    {
//        Console.Write("Введіть перше число: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введіть друге число: ");
//        int b = Convert.ToInt32(Console.ReadLine());

//        int start = Math.Min(a, b);
//        int end = Math.Max(a, b);

//        Console.WriteLine($"Парні числа від {start} до {end}:");
//        for (int i = start; i <= end; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.Write(i + " ");
//            }
//        }
//        Console.WriteLine();
//    }

//    static void Task8()
//    {
//        Console.Write("Введіть число: ");
//        string numStr = Console.ReadLine();
//        int n = numStr.Length;
//        int number = Convert.ToInt32(numStr);
//        int sum = 0;
//        int temp = number;

//        while (temp > 0)
//        {
//            int digit = temp % 10;
//            sum += (int)Math.Pow(digit, n);
//            temp /= 10;
//        }

//        if (sum == number)
//        {
//            Console.WriteLine($"{number} - число Армстронга");
//        }
//        else
//        {
//            Console.WriteLine($"{number} - не число Армстронга");
//        }
//    }

//    static void Task9()
//    {
//        Console.Write("Введіть число: ");
//        int number = Convert.ToInt32(Console.ReadLine());
//        int sum = 0;

//        for (int i = 1; i < number; i++)
//        {
//            if (number % i == 0)
//            {
//                sum += i;
//            }
//        }

//        if (sum == number)
//        {
//            Console.WriteLine($"{number} - досконале число");
//        }
//        else
//        {
//            Console.WriteLine($"{number} - не досконале число");
//        }
//    }
//}