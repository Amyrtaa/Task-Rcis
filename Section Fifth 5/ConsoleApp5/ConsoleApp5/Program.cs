using System;

using System.IO;

namespace fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask5.txt";

            using StreamReader reader = new StreamReader(path);

            int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();

            int max = numbers.Max();
            int min = numbers.Min();

            int sum = 0;
            int n = 0;
            bool condition = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == min)
                {
                    condition = true;
                }

                if (condition && numbers[i] != min)
                {
                    if (numbers[i] == max)
                    {
                        break;
                    }

                    sum += numbers[i];
                    n++;
                }
            }
            Console.WriteLine("Среднее арифметическое элементов расположенных между min и max: " + (sum / n));
        }
    }
}