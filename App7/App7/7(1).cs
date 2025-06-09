using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        var a = GetNumber("a");
        var b = GetNumber("b");

        if (StatementCheckUp(a, b))
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");

        Console.ReadKey();
    }
    static bool StatementCheckUp(int a, int b)
    {
        return (a > 0 && b > 0) || a > 0 || b > 0;
    }
    static int GetNumber(string Num)
    {
        Console.WriteLine($"Введите значение {Num}");
        return int.Parse(Console.ReadLine());
    }

}

