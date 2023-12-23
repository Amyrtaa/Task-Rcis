using System;
using System.Collections.Generic;

using System.IO;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../numsTask2.txt";

            using StreamReader reader = new StreamReader(path);

            string el = reader.ReadLine();

            string str = el + " ";
            
            while (el != null)
            {
                el = reader.ReadLine();
                str += el + " ";
            }
            
            Console.WriteLine(str);
        }
    }
}