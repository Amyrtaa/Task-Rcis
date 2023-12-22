using System;

using System.IO;

namespace sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int N = rand.Next(2, 10);
            Double[] mas_main = new Double[N];

            for (int i = 0; i < N; i++)
            {
                int n = rand.Next(-1, 1);
                if (n == -1)
                    mas_main[i] = (rand.NextDouble() * 1000) * n;
                else
                    mas_main[i] = rand.NextDouble() * 1000;
            }
            Console.WriteLine();

            List<Double> List_1 = new List<Double>();
            for (int i = 0; i < N; i++)
            {
                if (mas_main[i] > 0)
                {
                    List_1.Add(mas_main[i]);
                }
            }
            Double[] mas_1 = List_1.ToArray();
            
            
            List<Double> List_2 = new List<Double>();
            for (int i = 0; i < N; i++)
            {
                if (mas_main[i] < 0)
                {
                    List_2.Add(mas_main[i]);
                }
            }
            Double[] mas_2 = List_2.ToArray();

            
            foreach (var el in mas_main)
            {
                Console.Write("{0, -21}|", el);
            }
            Console.WriteLine();
            
            foreach (var el in mas_1)
            {
                Console.Write("{0, -21}|", el);
            }
            Console.WriteLine();
            
            foreach (var el in mas_2)
            {
                Console.Write("{0, -21}|", el);
            }
            Console.WriteLine();
        }
    }
}