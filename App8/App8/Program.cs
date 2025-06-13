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

        Console.WriteLine($"Полученное значение функции: {Function(x)}");

        Console.ReadKey();
    }
    static double Function(double x)
    {
        if (x > 0)
            return 1;
        else if (x < 0)
            return -1;

        return 0;
    }
    
}
