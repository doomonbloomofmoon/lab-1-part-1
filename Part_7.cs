using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    internal class Part_7 : Part
    {
        public override void Start()
        {
            string si = "Это строка для поиска";

            Regex theReg = new Regex(@"(\S+)\s");

            MatchCollection theMatches = theReg.Matches(si);

            foreach (Match theMatch in theMatches)
            {
                Console.WriteLine("theMatch.Length: {0}", theMatch.Length);

                if (theMatch.Length != 0)
                    Console.WriteLine("theMatch: {0}", theMatch.ToString());
            }
        }

    }
}

