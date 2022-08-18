using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace YoutubeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            String publicIP = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                    publicIP = stream.ReadToEnd();
            }
            //Search for the ip in the html
            int first = publicIP.IndexOf("Address: ") + 9,
                last = publicIP.LastIndexOf("</body>");
            publicIP = publicIP.Substring(first, last - first);

            Console.WriteLine("\t\t\tIP Adress: " + publicIP + "\n");
            Console.WriteLine("Welcome to 'YoutubeProject'");
            Console.WriteLine("Please write an youtube code or song name (Example: ao8Ujdx9ifM / Pour It Up): ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();

            // Check if this's yt code or search query.
            bool thereSpaces = false;
            int index = 0;
            while(index < input.Length)
                if (input[index++] == ' ') thereSpaces = true;

            System.Diagnostics.Process.Start(
                !thereSpaces ? ("http://www.youtube.com/watch?v=" + input) : ("http://www.youtube.com/results?search_query=" + input)
            );
            /*
             * Console.ReadKey();
             */
            Console.ReadKey();
        }
    }
}
