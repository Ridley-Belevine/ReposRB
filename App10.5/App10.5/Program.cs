using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число n");
        int n = int.Parse(Console.ReadLine());

        int reversedNumber = 0;
        int i = n; 

        while (i > 0)
        {
            int lastDigit = i % 10;
            reversedNumber = reversedNumber * 10 + lastDigit;
            i /= 10;
        }

        Console.WriteLine($"Число n в обратном порядке: {reversedNumber}");
    }

}