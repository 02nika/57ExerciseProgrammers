using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_48
{
    class GetInfoValue
    {
        internal static string ChooseWiseValue(List<Degrees> degrees, double info)
        {
            int count = 0;
            while (count <= degrees.Count)
            {
                if (degrees[count].Start <= info &&  info < degrees[count].End)
                {
                    return degrees[count].CardinalDirection;
                }
                count++;
            }

            return "other";
        }
        public static string ChooseByBinary(List<Degrees> degrees, double info)
        {
            double min = 0;
            double max = degrees.Last().End;
            while(min <= max)
            {
                double mid = (min + max) / 2;
                //var guess = degrees.Where(x => x.Start > mid && mid <= x.End);
                if (Math.Round(mid, 0) == info)
                    return degrees.Where(x => x.Start < mid && mid <= x.End).Select(x => x.CardinalDirection).Last();
                else if (mid > info)
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return "";
        }

    }
}
