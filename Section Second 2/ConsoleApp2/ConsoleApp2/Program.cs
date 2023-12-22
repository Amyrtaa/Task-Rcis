using System;
using System.Collections.Generic;

namespace P2ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[100];

            int n = 1;

            int odd = 0;

            for (int i = 0; i < 100; i++)
            {
                while (odd < n)
                {
                    odd++;
                    if (odd % 2 != 0)
                    {
                        break;
                    }
                }

                if (n <= odd)
                {
                    mas[i] = n;
                    n += 3;
                }

                else
                {
                    mas[i] = odd;
                }
            }

            Array.Reverse(mas);

            foreach (var num in mas)
            {
                Console.Write(num + ", ");
            }
        }
    }
}