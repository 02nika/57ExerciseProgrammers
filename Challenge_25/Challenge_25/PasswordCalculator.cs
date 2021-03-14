using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_25
{
    class PasswordCalculator
    {
        public static string PassCalc(string password)
        {
            if (int.TryParse(password, out int result))
                return "very weak";
            else if (CheckWeak(password))
                return "weak";
            else if (CheckString(password))
                return "strong";
            else if (CheckStrongString(password))
                return "very strong";
            else
                return "idk";
        }

        private static bool CheckWeak(string password)
        {
            bool numberCheck = false;

            foreach (char symbol in password)
            {
                if (int.TryParse(symbol.ToString(), out int result))
                    numberCheck = true;

            }
            if (password.Length < 8 && numberCheck == false)
                return true;
            else
                return false;
        }

        private static bool CheckStrongString(string pass)
        {
            bool number = false;
            bool otherSymbols = false;
            string symbols = "!@#$%^&*(){}/~`-_=+?><'][|";
            foreach (char symbol in pass)
            {
                if (int.TryParse(symbol.ToString(), out int result))
                    number = true;
                if (symbols.Contains(symbol))
                    otherSymbols = true;
            }
            if (pass.Length >= 8 && number == true && otherSymbols == true)
                return true;
            else
                return false;
        }

        private static bool CheckString(string pass)
        {
            bool number = false;
            bool otherSymbols = false;
            string symbols = "!@#$%^&*(){}/~`-_=+?><'][|";
            foreach (char symbol in pass)
            {
                if (int.TryParse(symbol.ToString(), out int result))
                    number = true;
                if (symbols.Contains(symbol))
                    otherSymbols = true;
            }
            if (pass.Length >= 8 && number == true && otherSymbols == false)
                return true;
            else
                return false;
        }
    }
}
