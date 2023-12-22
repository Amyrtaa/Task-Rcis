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

            string str = String.Join("", reader.ReadToEnd().Split('(').ToArray());
            str = String.Join(" ", str.Split(')'));

            Console.WriteLine(str);
        }
    }
}