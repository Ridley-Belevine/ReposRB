using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число m от 5 до 20");
        int m;
        if (!TryInputNumber(out m))
        {
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите целое число n от 5 до 20");
        int n;
        if (!TryInputNumber(out n))
        {
            Console.ReadKey();
            return;
        }

        if (m < 5 || m > 20 || n < 5 || n > 20)
        {
            Console.WriteLine("Числа не удовлетворяют промежутку от 5 по 20");
            Console.ReadKey();
            return;
        }

        var array = new int[m, n];

        var rnd = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = rnd.Next(100);

        Console.WriteLine();
        PrintArray(array);

        int searchValue = ReadInt("\nВведите число для поиска в массиве: ", 0, 99);
        Tuple<int, int> foundPosition = FindElement(array, searchValue);

        if (foundPosition != null)
        {
            Console.WriteLine($"Элемент найден на позиции: строка - {foundPosition.Item1}, столбец - {foundPosition.Item2}");
        }
        else
        {
            Console.WriteLine($"Элемент не найден в массиве.");
        }

        Console.WriteLine("\nМаксимальные элементы в каждой строке:");
        FindMaxInEachRow(array);
    }

    static bool TryInputNumber(out int number)
    {
        number = 0;
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Ошибка");
            return false;
        }

        number = n;
        return true;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j],2} ");

            Console.WriteLine();
        }
    }

    static int ReadInt(string number, int min, int max)
    {
        int value;
        do
        {
            Console.WriteLine(number);
        } while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max);
        return value;
    }

    static Tuple<int, int> FindElement(int[,] array, int value)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] == value)
                {
                    return Tuple.Create(i, j);
                }
            }
        }
        return null;
    }

    static void FindMaxInEachRow(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int maxValue = array[i, 0];
            int maxCol = 0;

            for (int j = 1; j < cols; j++)
            {
                if (array[i, j] > maxValue)
                {
                    maxValue = array[i, j];
                    maxCol = j;
                }
            }

            Console.WriteLine($"Строка {i}: максимальный элемент {maxValue} в столбце {maxCol}");
        }
    }
}
