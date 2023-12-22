using System;

using System.Collections.Generic;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите размер матрицы: ");

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 1;
                    if (i != 0 && j != 0)
                    {
                        int sum = 0;

                        for (int ni = 0; ni < i; ni++)
                        {
                            for (int nj = 0; nj < j; nj++)
                            {
                                if (ni + 1 == i)
                                    sum += matrix[i, nj];
                                if (nj + 1 == j)
                                    sum += matrix[ni, j];
                            }
                        }
                        matrix[i, j] = sum;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, -10}|", matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}