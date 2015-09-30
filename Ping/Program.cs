using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Ping
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = ConfigurationManager.AppSettings["Url"];

            try
            {
                using (var client = new WebClient())
                {
                    var result = client.DownloadString(url);
                    Console.WriteLine(String.Format("Called: {0} Result: {1}", url, result));
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(String.Format("Error calling: {0}", url));
            }


        }
    }
}
