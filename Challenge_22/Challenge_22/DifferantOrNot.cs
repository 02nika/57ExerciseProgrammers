using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_22
{
    class DifferantOrNot
    {
        public static bool CheckDifferance(int[] array1)
        {
            int minNum = -1;
            foreach (int num in array1)
            {
                if(num != minNum)
                {
                    minNum = num;
                }
                else
                {
                    Console.WriteLine("programs exited. (there is numbers that ar the same) ");
                    return false;
                }
            }
            return true;
        }
        
    }
}
