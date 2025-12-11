using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("МЕНЮ");
            Console.WriteLine("1. Стиснути масив (видалити 0)");
            Console.WriteLine("2. Від'ємні елементи спочатку");
            Console.WriteLine("3. Порахувати кількість входжень числа");
            Console.WriteLine("4. Поміняти місцями стовпці матриці");
            Console.WriteLine("0. Вихід");
            Console.Write("Вибір: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "0":
                    return;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }

    static void Task1()
    {
        int[] array = { 1, 0, 2, 0, 3, 0, 4, 5 };
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                array[count] = array[i];
                count++;
            }
        }

        for (int i = count; i < array.Length; i++)
        {
            array[i] = -1;
        }

        Console.WriteLine("\nРезультат:");
        PrintArray(array);
    }

    static void Task2()
    {
        int[] array = { 3, -2, 5, 0, -1, 4, -3, 2 };
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        int[] result = new int[array.Length];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                result[index] = array[i];
                index++;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                result[index] = array[i];
                index++;
            }
        }

        Console.WriteLine("\nРезультат:");
        PrintArray(result);
    }

    static void Task3()
    {
        int[] array = { 1, 3, 5, 3, 7, 3, 9, 3, 2 };
        Console.WriteLine("Масив:");
        PrintArray(array);

        Console.Write("\nВведіть число для пошуку: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }

        Console.WriteLine($"Число {number} зустрічається {count} разів");
    }

    static void Task4()
    {
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        Console.WriteLine("Початкова матрица 3x4:");
        PrintMatrix(matrix);

        Console.Write("\nВведіть номер першого стовпця (1-4): ");
        int col1 = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Введіть номер другого стовпця (1-4): ");
        int col2 = Convert.ToInt32(Console.ReadLine()) - 1;

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (col1 < 0 || col1 >= cols || col2 < 0 || col2 >= cols)
        {
            Console.WriteLine("Невірні номери стовпців");
            return;
        }

        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }

        Console.WriteLine("\nРезультат:");
        PrintMatrix(matrix);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}