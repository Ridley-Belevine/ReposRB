using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки (x, y)");

        var coordinates = Console.ReadLine();
        var n = coordinates.IndexOf(" ");
        var x = double.Parse(coordinates.Substring(0, n));
        var y = double.Parse(coordinates.Substring(n + 1));

        if (!IsDotBelongToArea(x, y))
            Console.WriteLine($"Точка принадлежит не заданной области");
        else
            Console.WriteLine($"Точка пренадлежит заданной области");

        Console.ReadKey();

    }
    static bool IsDotBelongToArea(double x, double y)
    {
        return (y <= 1.5 && y >= 0.5 && x >= 2);
    }

}
