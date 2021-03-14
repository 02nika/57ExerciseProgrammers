using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_37
{
    class PasswordGenerator
    {
        private int passwordLength { get; set; }
        private int specialCharacters { get; set; }
        private int numbers { get; set; }
        public PasswordGenerator(int length, int specChar, int nums)
        {
            passwordLength = length;
            specialCharacters = specChar;
            numbers = nums;
        }
        public string GeneratePassword()
        {
            List<int> numbersList = NumberGenerator.GetNumbers(numbers);

            List<char> charList = SpecialSymbolGenerator.GetSpecialList(specialCharacters);
            
            int elseSymbols = passwordLength - specialCharacters - numbers;

            List<char> normaList = NormalSymbolGenerator.GetNormalChars(elseSymbols);

            ArrayList resultOfPassword = GetFullPasswordBylist(numbersList, charList, normaList);
            return resultOfPassword.MyToString();
        }

        private ArrayList GetFullPasswordBylist(
            List<int> numbersList, 
            List<char> charList, 
            List<char> normaList)
        {
            ArrayList resultOfPassword = new ArrayList();
            
            resultOfPassword.AddValues(numbersList);
            resultOfPassword.AddValues(charList);
            resultOfPassword.AddValues(normaList);

            return resultOfPassword.Blend();

        }
    }
}
