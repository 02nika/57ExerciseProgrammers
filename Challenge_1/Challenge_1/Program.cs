using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("whats your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"hello {name}, nice to meet you <3");
            Console.ReadKey();
        }
    }
}
