using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    internal class Part_8 : Part
    {
        public override void Start()
        {
            string stringl = "04:03:27 127.0.0.0 GotDotNet.ru"; 

            Regex theReg = new Regex(@"(?<time>(\d|\:)+)\s" + @"(?<ip>(\d|\ .)+)\s" + @"(?<url>\S+)");
            
            MatchCollection theMatches = theReg.Matches(stringl);

            foreach (Match theMatch in theMatches)
            {
                    Console.WriteLine("\ntheMatch: {0}", theMatch.ToString());

                    Console.WriteLine("time: {0}", theMatch.Groups["time"]);

                    Console.WriteLine("ip: {0}", theMatch.Groups["ip"]);

                    Console.WriteLine("url: {0}", theMatch.Groups["url"]);

                    Console.WriteLine();
            }
        }
    }
}

