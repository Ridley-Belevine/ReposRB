using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения координат точки (x, y)");
        var coordinates = Console.ReadLine();

        var c = coordinates.IndexOf("");
        var x = double.Parse(coordinates.Substring(0, c));
        var y = double.Parse(coordinates.Substring(c + 1));

        if (DotPositionCheckUp(x, y))
            Console.WriteLine($"Точка с координатами ({x}; {y}) пренадлежит данной области");
        else
            Console.WriteLine($"Точка с координатами ({x}; {y}) не пренадлежит данной области");

            Console.ReadKey();
    }

    static bool DotPositionCheckUp(double x, double y)
    {
        return x >= 2 && y <= 1.5 && y >= 0.5;
    }
}
