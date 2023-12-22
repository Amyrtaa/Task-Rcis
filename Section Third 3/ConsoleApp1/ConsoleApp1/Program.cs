using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string input = "../../../input.txt";
        string output = "../../../output.txt";

        using (StreamWriter writer_1 = new StreamWriter(input, false))
        {
            writer_1.WriteLineAsync(input_f());
        }
        using (StreamReader reader = new StreamReader(input))
        {
            int[] numbers = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();   
            using (StreamWriter writer_2 = new StreamWriter(output, false))
            {
                writer_2.WriteAsync(output_f(numbers));   
            }
        }
    }

    static string input_f()
    {
        string str = "";
        int i = 1;
        Console.WriteLine("Ведите 10 чисел от 1 до 32");
        
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (0 < n && n <= 32)
            {
                if (i == 10)
                {
                    str += n.ToString();
                    break;
                }
                else
                {
                    str += $"{n} ";
                    i++;   
                }
            }
            else
            {
                Console.WriteLine("Некоректная информация\n");
            }
        }
        return str;
    }

    static string output_f(int[] numbers)
    {
        string str = "";

        Console.WriteLine("Ведите количество выданных билетов: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i=0; i<n; i++)
        {
            int[] mas_6 = new int[6];
            Random rand = new Random();
            for (int j = 0; j < 6; j++)
            {
                mas_6[j] = rand.Next(1, 32);
            }

            int the_probability_of_winning = 0;
            foreach (var el_ai in numbers) // выбранные организаторами 10 случайных чисел
            {
                foreach (var el_bj in mas_6) // 6 различных чисел
                {
                    if (el_ai == el_bj)
                    {
                        the_probability_of_winning++;
                    }
                }
            }

            foreach (var el in mas_6)
            {
                str += el + " ";
            }
            if (the_probability_of_winning >= 3)
            {
                str += "- Lucky\n";
            }
            else
            {
                str += "- Unlucky\n";
            }
        }

        return str;
    }
}