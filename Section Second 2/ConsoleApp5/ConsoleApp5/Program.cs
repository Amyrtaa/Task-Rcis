using System;
using System.Collections.Generic;

namespace fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> year = new Dictionary<string, List<int>>();

            string[] month = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

            for (int i = 0; i < 12; i++)
            {
                List<int> day_t = new List<int>();

                Random rand = new Random();

                for (int j = 0; j < 30; j++)
                {
                    if (i < 2 || i == 11)
                        day_t.Add(rand.Next(-40, -25));

                    else if (i >= 2 && i < 5)
                        day_t.Add(rand.Next(-10, 0));

                    else if (i >= 5 && i < 8)
                        day_t.Add(rand.Next(30, 49));

                    else
                        day_t.Add(rand.Next(-10, 0));
                }
                year.Add(month[i], day_t);
            }
            
            Dictionary<string, int> mean = sr(year);

            foreach (var m in mean.Keys)
            {
                Console.WriteLine(m + " ср. t: " + mean[m]);
            }
        }

        static Dictionary<string, int> sr(Dictionary<string, List<int>> year)
        {
            Dictionary<string, int> mean = new Dictionary<string, int>();
            
            foreach (var n in year.Keys)
            {
                int sum = 0;
                
                List<int> value = year[n];

                for (int j = 0; j < 30; j++)
                {
                    sum += Math.Abs(value[j]);
                }

                int sr = 1;
                if (n == "Январь" || n ==  "Январь" || n ==  "Февраль" || n ==  "Март" || n ==  "Апрель" || n ==  "Октябрь" || n ==  "Ноябрь" || n ==  "Декабрь")
                    sr *= sum / -30;
                else
                    sr *= sum / 30;
                

                mean.Add(n, sr);
            }

            return mean;
        }
    }
}