using System;
using System.Collections.Generic;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)

            {

                int n = rnd.Next() % 10;

                numbers[i] = n;

            }

            foreach (var i in numbers)

            {

                Console.Write(i + " ");

            }

            Console.WriteLine("\nMin el: " + numbers.Min());

            int min = numbers.Min();

            var deduce = "";

            List<int> index_el = new List<int>();

            for (int i=0; i<10; i++)

            {

                if (min == numbers[i])

                {

                    index_el.Add(i+1);

                }

            }

            Console.Write("Number of minimum element:");

            foreach (var i in index_el)

            {

                Console.Write(" " + i);

            }
        }
    }
}