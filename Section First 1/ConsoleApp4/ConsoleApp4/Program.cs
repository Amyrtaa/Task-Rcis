using System;
using System.Collections.Generic;

namespace fourth
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Веди размер массива: ");

            int n = int.Parse(Console.ReadLine());

            int[] mas = new int[n];

            Console.Write("Веди начало диапазона: ");

            int start = int.Parse(Console.ReadLine());

            Console.Write("Веди конец диапазона: ");

            int end = int.Parse(Console.ReadLine());

            f(mas, n, start, end);

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
        static int[] f(int[] mas, int n, int start, int end)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(start, end);
            }

            return mas;
        }
    }    
}