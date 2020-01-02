using System;
using System.Net;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string google = client.DownloadString("http://google.com");
            Console.WriteLine(google);
        }
    }
}
