using System;
using System.Collections.Generic;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] temperature = new int[12,30];

            Random rand = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    int day = i + 1;

                    if (day == 12 || day == 1 || day == 2)

                        temperature[i, j] = rand.Next(-40, -5);

                    if (day == 3 || day == 4 || day == 5)

                        temperature[i, j] = rand.Next(0, 10);

                    if (day == 6 || day == 7 || day == 8)

                        temperature[i, j] = rand.Next(10, 48);

                    if (day== 9 || day == 10 || day == 11)

                        temperature[i, j] = rand.Next(0, 10);
                }
            }

            int[] mean = Sr(temperature);

            Array.Sort(mean);

            foreach (var sr_el in mean)
            {
                Console.Write("{0, -7}|", sr_el);
            }
        }

        static int[] Sr(int[,] temperature)
        {
            int[] mean = new int[12];

            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    sum += temperature[i, j];
                }
                mean[i] = sum / 30;
                sum = 0;
            }
            
            return mean;
        }
    }
}