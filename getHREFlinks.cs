using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string testfile = "C:\\SF.Code\\test2\\test2\\TestFile.html";
            // or, string testfile = @"C:\SF.Code\test2\test2\TestFile.html";

            using (StreamReader sr = new StreamReader(testfile))
            {
                // Read the stream to a string, and write the string to the console.
                //String line = sr.ReadToEnd();
                //Console.WriteLine(line);

                String line = "";

                // Read line by line
                while ((line = sr.ReadLine()) != null)
                {
                    // extract all the href links
                    Match match = Regex.Match(line, @"href=\""(.*?)\""",
                    RegexOptions.IgnoreCase);

                    if (match.Success)
                    {
                        string result = match.Groups[1].Value;
                        Console.Write("href = \"{0}\"\n", result);

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
