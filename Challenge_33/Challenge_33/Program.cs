using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_33
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("What's your question? ");
            Console.ReadLine();

            string[] answers = { "Yes", "No", "Maybe", "Ask again later." };

            Output(answers);
            Console.ReadLine();
        }

        private static void Output(string[] answers)
        {
            Random rand = new Random();
            Console.WriteLine(answers[rand.Next(0, answers.Length)]);
        }
    }
}
