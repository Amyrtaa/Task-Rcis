using System;
using System.Collections.Generic;

namespace ConasoleApp1
{
    public static class FileName
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    p *= i;
                }
            }
            Console.WriteLine(p);
        }
    }   
}