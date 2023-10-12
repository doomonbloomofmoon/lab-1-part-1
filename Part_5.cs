using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    internal class Part_5
    {
        string FindMatch(string str, string strpat)
        {
            Regex pat = new Regex(strpat); 
            
            Match match = pat.Match(str); 
            
            string found = "";

            if (match.Success)
            {
                found = match.Value;

                Console.WriteLine("Строка = {0}\nОбразец = {1}\nНайдено = {2}", str, strpat, found);
            }

            Console.WriteLine();

            return (found);
        }
        public void TestSinglePat()
        {
            string str, strpat, found;

            Console.WriteLine("Поиск по образцу");
            
            str ="start";
            
            strpat =@"a\w+";
            
            found = FindMatch(str,strpat); 
            
            str ="fab77cd efg";
            
            found = FindMatch(str, strpat); 

            strpat = "a(b|d)*f"; 
            
            str = "fabadddbdf";

            found = FindMatch(str, strpat);
        }
    }
}

