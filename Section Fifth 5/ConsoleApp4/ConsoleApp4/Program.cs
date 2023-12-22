using System;

using System.IO;

namespace fourth
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = "../../../numsTask4.txt";

            using StreamReader reader = new StreamReader(path);
            
            int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();

            Array.Reverse(numbers);
            int max = numbers.Max();
            int sum = 0;
            foreach (var el in numbers)
            {
                if (max - 1 == el)
                {
                    max = el;
                    sum += el;
                }
            } 
            
            Console.WriteLine("Сумма элементов, отличающихся от максимального на 1: " + sum);
        }
    }
}