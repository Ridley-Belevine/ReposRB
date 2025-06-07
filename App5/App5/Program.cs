using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        double x = Arg(6, 2) + Arg(13, 5) + Arg(21, 3);

        Console.WriteLine("x =" + Math.Round(x, 3));
        Console.ReadKey();
    }
    static double Arg (double y, double z)
    {
        return (Math.Sqrt(y) + y) / z;
    }
}