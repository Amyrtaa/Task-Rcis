using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            int size = 0;
            foreach (char ch in str)
            {
                if (ch == ' ')
                    size++;
            }

            Console.WriteLine($"Количество слов находящихся в стоке {size + 1}");
            Console.WriteLine("Start " + str + " End");
        }
    }   
}