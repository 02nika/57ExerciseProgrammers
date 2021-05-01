using System;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is the input string? ");
            string text = Console.ReadLine();
            text = InputChecker.NullChecker(text);
            Console.WriteLine($"{text} has {text.GetLenght()} Characters. ");

            Console.ReadKey();
        }
    }
}
