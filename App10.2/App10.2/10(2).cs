using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество студентов в группе: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Количество студентов должно быть больше 0");
            return;
        }

        double totalHeight = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите рост студента {i + 1} в см: ");
            double height = double.Parse(Console.ReadLine());

            if (height <= 0)
            {
                Console.WriteLine("Рост должен быть положительным числом!");
                i--;
                continue;
            }

            totalHeight += height;
        }

        double averageHeight = totalHeight / n;
        Console.WriteLine($"Средний рост студентов в группе: {averageHeight} см");
    }

}
