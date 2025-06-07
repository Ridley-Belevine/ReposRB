using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x для вычисления фнукции y=f(x)");
        var x = float.Parse(Console.ReadLine());
        var y = Math.Sqrt(x + 1 / Math.Sqrt(Math.Pow(x, 2) + 4));

        Console.WriteLine("f(x) = " + y);
        Console.ReadKey();

    }
}
