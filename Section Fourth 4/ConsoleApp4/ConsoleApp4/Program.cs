using System;

using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask4.txt";

            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();

            int[] numbers = str.Split(' ').Select(int.Parse).ToArray();

            int same = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    same++;
                }
            }
            
            Console.WriteLine("Same numbers: " + same);
            
            reader.Close();
        }
    }
}