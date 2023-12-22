using System;
using System.Collections.Generic;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>();

            while (true)

            {

                string el = Console.ReadLine();

                if (el == "")

                {

                    break;

                }

                else

                {

                    elements.Add(el);

                }

            }

            int min = elements[0].Length;

            int max = elements[0].Length;

            foreach (var el in elements)

            {

                if (el.Length <= min)

                {

                    min = el.Length;

                }

                if (el.Length >= max)

                {

                    max = el.Length;

                }

            }

            string min_el = "";

            string max_el = "";

            foreach (var el in elements)

            {

                if (min == el.Length)

                {

                    if (min_el == "")

                        min_el += el;

                    else

                        min_el += ", " + el;

                }

                if (max == el.Length)

                {

                    if (max_el == "")

                        max_el += el;

                    else

                        max_el += ", " + el;

                }

            }

            Console.WriteLine("Minimum element: " + min_el);

            Console.WriteLine("Maximum element: " + max_el);
        }
    }
}