using System; 

using System.IO;

namespace sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Веди вещественное число оси х, а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Веди вещественное число оси х, b: ");
            double b = double.Parse(Console.ReadLine());

            double x1 = -2;
            double x2 = 2;
            double x3 = 0;
            double y1 = -3;
            double y2 = -3;
            double y3 = 2;

            double y_base = -3;

            
            double S = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            if (x1 <= a && a <= x2 && y_base <= b && b <= y3)
            {
                double S1 = 0.5 * Math.Abs(x1 * (y2 - b) + a * (y1 - y2) + x2 * (b - y1));
                double S2 = 0.5 * Math.Abs(a * (y2 - y3) + x2 * (y3 - b) + x3 * (b-y2));
                double S3 = 0.5 * Math.Abs(x1 * (b - y3) + x3 * (y1 - b) + a * (y3 - y1));
                if (S1+S2+S3 == S)
                {
                    Console.WriteLine($"{a} и {b} принадлежит заштрихованной области");
                }
                else
                {
                    Console.WriteLine($"{a} и {b} не принадлежит заштрихованной области");
                }
            }
            else
            {
                Console.WriteLine($"{a} и {b} не принадлежит заштрихованной области");
            }
        }
    }
}