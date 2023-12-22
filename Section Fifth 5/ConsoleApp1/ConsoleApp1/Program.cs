using System;

using System.IO;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask1.txt";

            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();

            int[] numbers = str.Split(' ').Select(int.Parse).ToArray();

            int min = numbers.Min();

            bool run = false;
            int multiplication = 1;
            foreach (var el in numbers)
            {
                if (el == min)
                {
                    run = true;
                }

                if (run && el != min)
                {
                    multiplication *= el;
                }
            }
            Console.WriteLine("Произведение чисел после минимального числа: " + multiplication);
            
            reader.Close();
        }
    }
}