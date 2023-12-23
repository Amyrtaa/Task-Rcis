using System;
using System.Collections.Generic;


namespace fifth
{
    class Program
    {
        static void Main()
        {
            Console.Write("ведите количество строк матрицы: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ведите количество столбцов матрицы: ");
            int m = int.Parse(Console.ReadLine());
            var matrix = new int[n, m + 1];

            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(0, 2);
                    sum += matrix[i, j];
                    if (m - 1 == j)
                    {
                        if (sum % 2 == 0)
                            matrix[i, j + 1] = 0;
                        else
                            matrix[i, j + 1] = 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m+1; j++)
                {
                    if (j != m)
                        Console.Write("{0, 2}|", matrix[i, j]);
                    else
                        Console.Write("{0, 2}|", " = " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}