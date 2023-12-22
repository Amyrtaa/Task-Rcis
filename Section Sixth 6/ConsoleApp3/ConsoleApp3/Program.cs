using System;
using System.IO;

namespace thrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../number.txt";

            int number;
            using StreamReader reader = new StreamReader(path);
            {
                number = int.Parse(reader.ReadToEnd());
            }
            
            if (number % 2 == 0)
            {
                Console.Write($"Число {number}: чётно");
                if (number % 10 == 0)
                {
                    Console.WriteLine(" и кратно 10");
                }
                else
                {
                    Console.WriteLine(" и некратно 10");
                }
            }
            else
            {
                Console.Write($"Число {number}: нечётно и некратно 10");
            }
        }
    }
}