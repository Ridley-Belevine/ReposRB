using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число числа a и b, при этом число a должно быть меньше числа b");

        Console.WriteLine("Число a = ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Число b = ");
        int b = int.Parse(Console.ReadLine());

        if (a <= 0 || b <= a)
        {
            Console.WriteLine("Должно выполняться условие 0 < a < b");
            return;
        }

        double sumOfCubes = 0;
        for (int i = a; i <= b; i++)
        {
            sumOfCubes += Math.Pow(i, 3);
        }

        Console.WriteLine($"Сумма кубов чисел от {a} до {b} равна: {sumOfCubes}");

        Console.ReadKey();
    }

}
