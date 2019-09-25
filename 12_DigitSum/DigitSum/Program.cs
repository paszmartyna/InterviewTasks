using System;
using System.Linq;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int size = int.Parse(Console.ReadLine());

                int[] numbers = new int[size];

                string input = Console.ReadLine();

                string[] split = input.Split(" ");

                for (int i = 0; i < size; i++)
                {
                    numbers[i] = int.Parse(split[i]);
                }

                int index = FindIndexOfMaxDigitSum(numbers);

                Console.WriteLine($"{index}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int SumDigit(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public static int FindIndexOfMaxDigitSum(int[] values)
        {
            int num = values.Where(x => SumDigit(x) == values.Max(y => SumDigit(y)))
                            .Max(x => x);

            int index= Array.IndexOf(values, num);

            return index;

        }
    }
}
