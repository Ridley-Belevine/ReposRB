using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение первого члена арифметической прогрессии a");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение разности арифметической прогрессии d");
        int d = int.Parse(Console.ReadLine());

        int[] progression = new int[10];
        for (int i = 0; i < 10; i++)
        {
            progression[i] = a + i * d;
        }

        Console.WriteLine("Первые 10 членов прогрессии: ");
        PrintArray(progression);

    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }

}