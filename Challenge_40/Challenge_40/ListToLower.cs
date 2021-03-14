using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_40
{
    public class ListToLower
    {
        public static IEnumerable<Employees> ToLower(List<Employees> result)
        {
            result.ForEach(z =>
            {
                z.firstName = z.firstName.ToLower();
                z.lastName = z.lastName.ToLower();
                z.Position = z.Position.ToLower();
            });

            IEnumerable<Employees> result2 = result.OrderBy(e => e.lastName);
            return result2;
        }
    }
}
