using System;

using System.IO;

namespace fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = -1;
            int x2 = 3;
            int y1 = -2;
            int y2 = 4;

            Console.Write("Ведите вещественное число для оси x, a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ведите вещественное число для оси y, b: ");
            double b = double.Parse(Console.ReadLine());
            
            if (a >= x1 && a <= x2)
            {
                if (b >= y1 && b <= y2)
                    Console.WriteLine($"Кордината с значениями x = {a} и y = {b}, принадлежит заштрихованной области");
                else
                    Console.WriteLine($"Кордината с значениями x = {a} и y = {b}, не принадлежит заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Кордината с значениями x = {a} и y = {b}, не принадлежит заштрихованной области");
            }
            
        }
    }
}