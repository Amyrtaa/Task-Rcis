using System;
using System.Collections.Generic;

namespace second
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Ведите несколько натуральных чисел с клавиатуры: ");

            List<int> numbers = new List<int>();

            while (true)

            {

                int number = int.Parse(Console.ReadLine());

                if (number == 0)

                {

                    break;

                }

                else

                {

                    numbers.Add(number);

                }

            }

            int sum = 0;

            int multiplication = 1;

            foreach (var i in numbers)

            {

                sum += i;

                multiplication *= i;

            }

            double arithmetic_mean = sum / numbers.Count;

            Console.WriteLine("Sum: " + sum);

            Console.WriteLine("Multiplication: " + multiplication);

            Console.WriteLine("arithmetic mean: " + arithmetic_mean);

        }
    }
}