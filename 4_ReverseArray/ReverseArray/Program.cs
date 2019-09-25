#define C_STYLE
//#define NET_STYLE

using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmpSize;
            string input;
            int size;
            int[] numbers;
            int[] reversedNumbers;

            tmpSize = Console.ReadLine();
            size = int.Parse(tmpSize);
            input = Console.ReadLine();

            numbers = input.Split(" ").Select(Int32.Parse).ToArray();
            reversedNumbers = new int[size];

            // Using .NET framework is just: 
#if NET_STYLE
            reversedNumbers = numbers;
            Array.Reverse(reversedNumbers);
#endif
            // C style algorithm
#if C_STYLE
            int j = 0;
            for (int i = size-1; i >= 0; i--)
            {
                reversedNumbers[j] = numbers[i];
                j++;
            }
#endif
            foreach (int number in reversedNumbers)
            {
                Console.Write($"{number} ");
            }

            Console.ReadKey();
        }
    }
}
