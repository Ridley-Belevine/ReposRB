using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение аргумента функции");
        var x = float.Parse(Console.ReadLine());

        Console.WriteLine($"Значение функции: {Function(x)}");

        Console.ReadKey();
    }
    static double Function(float x)
    {
        if (x > 0)
            return 1;
        else if (x == 0)
            return 0;
        return -1;
    }

}
