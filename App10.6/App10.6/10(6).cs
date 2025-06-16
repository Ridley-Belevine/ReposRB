using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начало промежутка a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите конец промежутка b, большее a: ");
        int b = int.Parse(Console.ReadLine());

        if (a >= b)
        {
            Console.WriteLine("Ошибка: a должно быть меньше b.");
            return;
        }

        Console.WriteLine("Введите сумму делителей n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Числа от {a} до {b}, у которых сумма делителей равна {n}:");

        bool found = false;

        for (int num = a; num <= b; num++)
        {
            int sumOfDivisors = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            if (sumOfDivisors == n)
            {
                Console.WriteLine(num);
                found = true;
            }

        }

        if (!found)
        {
            Console.WriteLine("Таких чисел нет");
        }

    }

}
