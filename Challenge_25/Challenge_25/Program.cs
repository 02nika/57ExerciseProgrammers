using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_25
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("enter password : ");
            string inputPassword = Console.ReadLine();
            string result = PasswordCalculator.PassCalc(inputPassword);
            Console.WriteLine($"The password '{inputPassword}' is a {result} password");
            Console.ReadLine();
        }
    }
}
