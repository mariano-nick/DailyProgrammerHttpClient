using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyProgrammerWebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlDis = new DissectHttpUrl("http://httpbin.org/blah/blah/");
            urlDis.Dissect();
            var httpGet = new FetchHttpContentGet(urlDis);
            // ENDED AT ADDING PAGE TO GET LINE
            httpGet.Fetch();
            Console.WriteLine("Press any key to continue..."); 


        }
    }
}
