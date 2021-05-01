using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_2
{
    static class InputChecker
    {
        public static string NullChecker(string text)
        {
            while (text == "")
            {
                Console.Write("please enter something\n\nwhat is the input string? ");
                text = Console.ReadLine();
            }
            return text;
        }

    }
}
