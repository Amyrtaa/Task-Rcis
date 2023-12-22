using System;
using System.IO;

namespace second
{
    class Project
    {
        static async Task Main(string[] args)
        {
            string path = "../../../nums.txt";
            
            using StreamReader reader = new StreamReader(path);

            int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();
            
            reader.Close();
            
            using StreamWriter writer = new StreamWriter(path, false);
            
            string no_numbers = "";
            
            foreach (var el in numbers)
            {
                if (el % 2 != 0)
                {
                    no_numbers += $"{el} ";
                }
            }

            writer.WriteAsync(no_numbers);
            writer.Close();
        }
    }
}