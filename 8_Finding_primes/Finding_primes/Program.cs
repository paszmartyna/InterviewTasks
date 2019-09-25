using System;

namespace Finding_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTests = int.Parse(Console.ReadLine());
            int[] result = new int[numberOfTests];
           
            int i = 0;
     
            string input;

            do
            {
                input = Console.ReadLine();
                string[] split = input.Split(" ");
                result[i] = countPrimes( int.Parse(split[0]), int.Parse(split[1]));
                i++;
            }
            while (i != numberOfTests);

            foreach (var item in result)
            {

                Console.WriteLine($"{item}");
            }

            Console.ReadKey();
        }

        public static int countPrimes(int  a, int b)
        {
            int sum = 0;
            int i = a;

            while (i != b)
            {
                if (IsPrime(i))
                {
                    sum++;
                }
                i++;
            }
            return sum;
        }


        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

    }
}
