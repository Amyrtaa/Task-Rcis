using System;

using System.IO;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask3.txt";

            using StreamReader reader = new StreamReader(path);

            int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();

            int min = numbers.Min();

            int sum = 0;
            int i = 0;
            int mean = 0;
            foreach (var el in numbers)
            {
                if (el != min)
                {
                    sum += el;
                    i++;
                }
                else
                {
                    mean = sum / i;
                    break;
                }
            }

            Console.WriteLine("Среднее арифметическое чисел до минимального: " + mean);
            
            reader.Close();
        }
    }
}