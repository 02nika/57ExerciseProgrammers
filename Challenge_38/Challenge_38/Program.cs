using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Challenge_38
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"D:\nika\c#\Challenge_57\Challenge_38\Challenge_38\text.txt");

            string[] stringArray = text.Split(' ');
            IEnumerable<int> nums = stringArray.FilterEvenNumbers();


            Console.Write("The even numbers are:  ");
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }



            Console.ReadKey();
        }
    }
}
