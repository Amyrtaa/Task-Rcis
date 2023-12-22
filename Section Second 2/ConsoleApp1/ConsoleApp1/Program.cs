using System;
using System.Collections.Generic;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            int n = 1;
            
            for (int i = 0; i < 100; i++)
            {
                mas[i] = n;
                n += 3;
            }

            Array.Reverse(mas);

            foreach (var num in mas)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
        }
    }
}