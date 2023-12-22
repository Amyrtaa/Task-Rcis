using System;

using System.IO;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask2.txt";

            using StreamReader reader = new StreamReader(path);

            double[] numbers = reader.ReadToEnd().Split(';').Select(double.Parse).ToArray();

            Array.Sort(numbers);

            string text = String.Join(";", numbers);

            Console.WriteLine(text);
            
            reader.Close();
            
            using StreamWriter writer = new StreamWriter(path, false);
            writer.WriteAsync(text);
            
            writer.Close();
        }
    }
}