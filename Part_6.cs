using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    internal class Part_6
    {
        public void TestSinglePat()
        {
            string str, strpat;

            Console.WriteLine("око и рококо");

            strpat = "око";

            str = "рококо";

            FindMatches(str, strpat);
        }

        void FindMatches(string str, string strpat)
        {
            Regex pat = new Regex(strpat); 
            
            MatchCollection match = pat.Matches(str);

            Console.WriteLine("Строка = {0}\nОбразец = {1}\nНайдено = {2}", str, strpat, match.Count);
        }
    }
}

