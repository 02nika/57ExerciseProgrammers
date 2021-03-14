using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_15
{
    class Program
    {
        static void PassWordChecker(string inputPass)
        {
            string storedPass = "123NWtati@";
            if(inputPass == storedPass)
                Console.WriteLine("Welcome!");
            else
                Console.WriteLine("I don't know you.");
        }
        static void Main()
        {
            Console.Write("What is the password? ");
            string InputString = Console.ReadLine();

            PassWordChecker(InputString);

            Console.ReadKey();
        }
    }
}
