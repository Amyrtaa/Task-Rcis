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

            string[] str = reader.ReadToEnd().Split(' ', '.', ',', '-', '!', '?').ToArray();

            foreach (var el in str)
            {
                if (el.Length % 2 != 0)
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}