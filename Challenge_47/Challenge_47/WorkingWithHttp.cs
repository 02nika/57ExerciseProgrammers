using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_47
{
    class WorkingWithHttp
    {
        public static string JsonToString(string httpUrl)
        {
            WebClient wc = new WebClient();
            string json = wc.DownloadString(httpUrl);
            return json;
        } 
    }
    
}
