using System;
using System.Linq;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "../../../numsTask2.txt";

            using StreamReader reader = new StreamReader(file);

            string str = reader.ReadToEnd();

            double[] numbers = str.Split(';').Select(Double.Parse).ToArray();

            double sum = 0;
            
            foreach (var i in numbers)
            {
                if (i > 0)
                    sum += i;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}