using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите двузначное число");
        int number = int.Parse(Console.ReadLine());
        int digits = number / 10;
        int units = number % (digits * 10);
        int sum = digits + units;
        int mult = digits * units;

        Console.WriteLine($"{digits}, {units}, {sum}, {mult}");
        Console.ReadKey();

    }

}
