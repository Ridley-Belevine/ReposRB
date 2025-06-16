using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел в последовательности: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Количество чисел должно быть положительным");
            return;
        }

        Console.WriteLine("Введите первое число последовательности: ");
        int firstNumber = int.Parse(Console.ReadLine());
        bool isOdd = firstNumber % 2 != 0;
        int sum = firstNumber;
        int i = 1;

        while (i < n)
        {
            Console.WriteLine("Введите следующее число: ");
            int nextNumber = int.Parse(Console.ReadLine());

            if ((isOdd && nextNumber % 2 != 0) || (!isOdd && nextNumber % 2 == 0))
            {
                sum += nextNumber;
                i++;
            }
            else
            {
                break;
            }

        }

        Console.WriteLine($"Полученная сумма последовательности чисел: {sum}");
    }

}