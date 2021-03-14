using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_27
{
    class ValidateZipCode : IValidateInput
    {
        public bool ValidateInput(string zipCode)
        {
            if(!int.TryParse(zipCode, out int result))
            {
                Console.WriteLine("The ZIP code must be numeric.");
                return false;
            }
            return true;
        }
    }
}
