using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_51
{
    class WorkingWithJson
    {
        public static Dictionary<string, List<DateAndNode>> JsonToDict(string jsonString)
        {
            dynamic jsonDyn = JObject.Parse(jsonString);

            Dictionary<string, List<DateAndNode>> information = new Dictionary<string, List<DateAndNode>>();
            List<DateAndNode> list1 = new List<DateAndNode>();

            foreach (var item in jsonDyn.ListofNodes)
            {
                list1.Add(new DateAndNode()
                {
                    Date = item.Date,
                    Node = item.Node,
                });
            }


            

            information.Add("ListofNodes", list1);
            return information;
        }
    }
}
