using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число n");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите натуральное число k, на которое будут кратными цифры числа n, при этом k должно быть в пределе от 1 по 9");
        int k = int.Parse(Console.ReadLine());

        if (k < 0 || k > 9)
        {
            Console.WriteLine("Ошибка: k должно быть в диапазоне от 0 до 9");
            return;
        }

        int count = 0;
        int i = n;

        while (i > 0 && i != 0)
        {
            int digit = i % 10;

            if (digit % k == 0)
            {
                count++;
            }

            i /= 10;
        }

        Console.WriteLine($"Количество цифр, кратных k: {count}");
        Console.ReadKey();
    }

}
