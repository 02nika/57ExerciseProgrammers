using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Challenge_37
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What's the minimum length? ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("How many special characters? ");
            int specCharacters = int.Parse(Console.ReadLine());
            Console.Write("How many numbers ? ");
            int numbers = int.Parse(Console.ReadLine());

            PasswordGenerator pG1 = new PasswordGenerator(length, specCharacters, numbers);
            
            string one = pG1.GeneratePassword();

            Thread.Sleep(1000);
            PasswordGenerator pG2 = new PasswordGenerator(length, specCharacters, numbers);
            string two = pG2.GeneratePassword();
            Console.WriteLine("here is two variants of password: ");

            Console.WriteLine(one);
            Console.WriteLine(two);

            Console.ReadLine();
        }
    }
}
