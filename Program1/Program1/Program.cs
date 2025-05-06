using System;
using MathOperationsLib1;

class Program1
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Максимум из трех выражений (7.4)");
            Console.WriteLine("2. Количество повторений числа в массиве (7.9)");
            Console.WriteLine("3. Количество повторений символа в строке (7.10)");
            Console.WriteLine("4. Максимальный элемент и количество максимумов (7.11)");
            Console.WriteLine("5. Замена диагонали матрицы нулями (7.16)");
            Console.WriteLine("6. Замена отрицательных элементов матрицы единицами (7.17)");
            Console.WriteLine("7. Сумма минимальных элементов по строкам (7.18)");
            Console.WriteLine("8. Реверс строки (7.21)");
            Console.WriteLine("9. Добавление символов в начало строки (7.22)");
            Console.WriteLine("10. Строка из k символов (7.23)");
            Console.WriteLine("11. Сумма первых n элементов массива (7.24)");
            Console.WriteLine("0. Выход");

            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Task7_4();
                    break;
                case "2":
                    Task7_9();
                    break;
                case "3":
                    Task7_10();
                    break;
                case "4":
                    Task7_11();
                    break;
                case "5":
                    Task7_16();
                    break;
                case "6":
                    Task7_17();
                    break;
                case "7":
                    Task7_18();
                    break;
                case "8":
                    Task7_21();
                    break;
                case "9":
                    Task7_22();
                    break;
                case "10":
                    Task7_23();
                    break;
                case "11":
                    Task7_24();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void Task7_4()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        double result = Calculations.MaxOfThreeExpressions(a, b);
        Console.WriteLine($"Максимальное значение: {result:F4}");
    }

    static void Task7_9()
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 3, 2, 7, 8 };
        Console.WriteLine("Массив: " + string.Join(", ", array));

        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int count = Calculations.CountNumberInArray(array, n);
        Console.WriteLine($"Число {n} встречается {count} раз(а)");
    }

    static void Task7_10()
    {
        string str = "Hello, world! This is a test string.";
        Console.WriteLine("Строка: " + str);

        Console.Write("Введите символ: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = Calculations.CountCharInString(str, ch);
        Console.WriteLine($"Символ '{ch}' встречается {count} раз(а)");
    }

    static void Task7_11()
    {
        int[] array = { 1, 5, 3, 5, 2, 5, 7, 7, 9, 9 };
        Console.WriteLine("Массив: " + string.Join(", ", array));

        var (max, count) = Calculations.FindMaxAndCount(array);
        Console.WriteLine($"Максимальный элемент: {max}, встречается {count} раз(а)");
    }

    static void Task7_16()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Calculations.ZeroMatrixDiagonal(matrix);

        Console.WriteLine("Матрица после замены диагонали:");
        PrintMatrix(matrix);
    }

    static void Task7_17()
    {
        int[,] matrix = {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Calculations.ReplaceNegativesWithOnes(matrix);

        Console.WriteLine("Матрица после замены отрицательных элементов:");
        PrintMatrix(matrix);
    }

    static void Task7_18()
    {
        int[,] matrix = {
            { 3, 1, 4 },
            { 2, 5, 9 },
            { 6, 5, 3 }
        };

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);

        int sum = Calculations.SumOfRowMinimals(matrix);
        Console.WriteLine($"Сумма минимальных элементов по строкам: {sum}");
    }

    static void Task7_21()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string reversed = Calculations.ReverseString(input);
        Console.WriteLine($"Реверсированная строка: {reversed}");
    }

    static void Task7_22()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string result = Calculations.AddSymbolsToString(input);
        Console.WriteLine($"Результат: {result}");
    }

    static void Task7_23()
    {
        Console.Write("Введите символ: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Введите количество k: ");
        int k = int.Parse(Console.ReadLine());

        string result = Calculations.CreateStringFromChar(ch, k);
        Console.WriteLine($"Результат: {result}");
    }

    static void Task7_24()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Массив: " + string.Join(", ", array));

        Console.Write("Введите количество элементов n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = Calculations.SumFirstNElements(array, n);
        Console.WriteLine($"Сумма первых {n} элементов: {sum}");
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