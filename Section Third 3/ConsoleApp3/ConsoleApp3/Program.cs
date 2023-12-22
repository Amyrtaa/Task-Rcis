using System;
using System.IO;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../file.txt";

            using StreamReader reader = new StreamReader(path);

            int[] height = reader.ReadToEnd().Split(' ').Select(int.Parse).ToArray();
            int i = height.Length;

            int max_S = 0;
            int left = 0;
            int right = i - 1;
            
            while (left < right)
            {
                int width = right - left;
                int h = Math.Min(height[left], height[right]);
                max_S = Math.Max(max_S, width * h);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine("S: " + max_S);
        }
    }
}