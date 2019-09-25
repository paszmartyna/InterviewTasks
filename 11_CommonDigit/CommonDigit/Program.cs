using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size >= 2 && size <= 20)
            {
                string input = Console.ReadLine();

                Console.WriteLine($"{GetCommonDigit(input)}");
            }
            else
            {
                Console.WriteLine($"Wrong number of integers. Range between 2 and 20 inclusive.");
            }
        }

        public static int GetCommonDigit(string input)
        {
            string str = input.Replace(" ", "");
            int[] numbers = new int[10];
            int i = 0;
            while (i < str.Length)
            {
                numbers[str[i] - '0']++;
                i++;
            }
            int maximum = numbers[9];
            int indexOfMax = 9;
            for (int j = 9; j >= 0; j--)
            {
                if (numbers[j] > maximum)
                {
                    maximum = numbers[j];
                    indexOfMax = j;
                }
            }
            return indexOfMax;

        }

    }
}
