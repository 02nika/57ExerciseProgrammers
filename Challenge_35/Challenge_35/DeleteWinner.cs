using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_35
{
    static class DeleteWinner
    {
        public static ArrayList SetWinner(this ArrayList list, string winner)
        {
            list.Remove(winner);
            return list;
        }
    }
}
