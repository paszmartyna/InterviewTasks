using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(IsPalindrome(input) ? "YES" : "NO");
        }

        public static bool IsPalindrome(string value)
        {
            Regex rgx = new Regex("[^a-z]");
            value = rgx.Replace(value.ToLower(), "");

            int start = 0, end = value.Length - 1;
            int middle = (int)(value.Length / 2) - 1;

            bool result = true;
            while(start <= middle)
            {
                result = result && value[start] == value[end];
                start++;
                end--;
            }

            return result;
        }
    }
}
