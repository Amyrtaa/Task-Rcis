using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask3.txt";

            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();

            int[] numbers = str.Split(',').Select(int.Parse).ToArray();

            Array.Sort(numbers);
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
                    Console.Write(numbers[i] + " ");
            }

            foreach (var el in numbers)
            {
                if (el < 0)
                    Console.Write(el + " ");
            }

            foreach (var el in numbers)
            {
                if (el == 0)
                {
                    Console.Write(el + " ");
                    break;
                }
            }

            int min = numbers.Min();
            int max = numbers.Max();

            Console.WriteLine();
            Console.WriteLine("Отношение " + min + " и " + max + " = " + (min / max));
            Console.WriteLine("Отношение " + max + " и " + min + " = " + (max / min));


            reader.Close();
        }
    }
}