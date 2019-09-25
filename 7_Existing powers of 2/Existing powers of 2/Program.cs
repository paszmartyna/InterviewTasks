using System;
using System.Collections.Generic;
using System.Linq;

namespace Existing_powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<uint> input = new List<uint>();
                string str;

                do
                {
                    str = Console.ReadLine();
                    if (str != "")
                    {
                        input.Add(uint.Parse(str));
                    }
                }
                while (str != "");

                //First solution
                List<uint> result = input.Where(x => isPowerOfTwo(x))
                                            .Distinct()
                                            .OrderBy(x => x)
                                            .ToList();
                if (result.Count != 0)
                {
                    foreach (uint i in result)
                    {
                        Console.Write($"{i}, ");
                    }
                }
                else
                {
                    Console.WriteLine("NA");
                }

                //second solution
                List<uint> result2 = input.Where(x => isPowerOfTwo2(x))
                                            .Distinct()
                                            .OrderBy(x => x)
                                            .ToList();

                Console.ReadKey();
            }

            catch (Exception)
            {
                Console.WriteLine("Something Wrong");
                Console.ReadKey();
            }

        }
        public static bool isPowerOfTwo2(uint x)
        {
            while (((x % 2) == 0) && x > 1)
            {
                x /= 2;
            }
            return (x == 1);
        }

        public static bool isPowerOfTwo(uint x)
        {
            if ((x != 0) && ((x & (x - 1)) == 0))
                return true;
            else
                return false;
        }
    }
}
