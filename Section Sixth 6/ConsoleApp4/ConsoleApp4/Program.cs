using System;
using System.IO;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numbers.txt";

            using StreamReader reader = new StreamReader(path);

            int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            while (true)
            {
                Console.Write("Выбери положительное число а: ");
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    break;
                }
                
                foreach (var el in numbers)
                {
                    if (el % a == 0 && a <= el)
                    {
                        sum += el;
                    }
                }
            }
            Console.WriteLine("Сумма чисел делящихся нацело: " + sum);
        }
    }
}