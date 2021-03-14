using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_24
{
    class Program
    {
        private static string ReverseString(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        public static bool IsAnagram(string first, string second)
        {
            string reverseFirst = ReverseString(first);
            
            if (first.Length != second.Length)
                return false;
            else if (reverseFirst != second)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings and I'll tell you if they are anagrams:");
            Console.Write("Enter the first string: ");
            string first = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string second = Console.ReadLine();

            bool result =  IsAnagram(first, second);
            ResultInConsole(result, first, second);
            Console.ReadLine();

        }

        private static void ResultInConsole(bool result, string first, string second)
        {
            if (result == true)
            {
                Console.WriteLine($"'{first}' and '{second}' are anagrams.");
            }
            else
                Console.WriteLine($"'{first}' and '{second}' are not anagrams.");
        }
    }
}
