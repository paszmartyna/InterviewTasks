using System;
using System.Linq;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int[] numbers1 = new int[10];
            int[] numbers2 = new int[10];

            int[] splitLine1 = line1.Split(" ").Select(Int32.Parse).ToArray();
            int[] splitLine2 = line2.Split(" ").Select(Int32.Parse).ToArray();

            int i = 0;
            while(i < splitLine1.Length)
            {
                numbers1[splitLine1[i]]++;
                i++;
            }

            i = 0;
            while (i < splitLine2.Length)
            {
                numbers2[splitLine2[i]]++;
                i++;
            }

            bool result = true;
            for(int j = 0; j < 10; j++)
            {
                if (numbers1[j] != numbers2[j])
                {
                    result = false;
                    break;
                }
            }

            Console.WriteLine(result ? "YES" : "NO");
            Console.ReadKey();
        }
    }
}
