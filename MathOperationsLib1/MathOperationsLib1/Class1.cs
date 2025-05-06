using System;

namespace MathOperationsLib1
{
    public static class Calculations
    {
        // 7.4. Максимум из трех выражений
        public static double MaxOfThreeExpressions(double a, double b)
        {
            double x = Math.Pow(Math.Cos(a + b), 2);
            double y = Math.Sin(a + b);
            double z = Math.Pow(a, b);

            return Math.Max(Math.Max(x, y), z);
        }

        // 7.9. Количество повторений числа в массиве
        public static int CountNumberInArray(int[] array, int n)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n) count++;
            }
            return count;
        }

        // 7.10. Количество повторений символа в строке
        public static int CountCharInString(string str, char ch)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == ch) count++;
            }
            return count;
        }

        // 7.11. Максимальный элемент и количество максимумов в массиве
        public static (int max, int count) FindMaxAndCount(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив пуст");

            int max = array[0];
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] == max)
                {
                    count++;
                }
            }

            return (max, count);
        }

        // 7.16. Замена элементов диагонали матрицы на нули
        public static void ZeroMatrixDiagonal(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = 0;
            }
        }

        // 7.17. Замена всех отрицательных чисел матрицы на единицы
        public static void ReplaceNegativesWithOnes(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0) matrix[i, j] = 1;
                }
            }
        }

        // 7.18. Сумма минимальных элементов матрицы по строкам
        public static int SumOfRowMinimals(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min) min = matrix[i, j];
                }
                sum += min;
            }

            return sum;
        }

        // 7.21. Реверс строки
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7.22. Добавление символов в начало строки
        public static string AddSymbolsToString(string input)
        {
            return "++++-----" + input;
        }

        // 7.23. Строка из k символов
        public static string CreateStringFromChar(char ch, int k)
        {
            return new string(ch, k);
        }

        // 7.24. Сумма первых n элементов массива
        public static int SumFirstNElements(int[] array, int n)
        {
            if (n > array.Length) n = array.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
