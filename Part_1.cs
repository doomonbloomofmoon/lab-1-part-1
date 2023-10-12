using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    internal class Part_1 : Part
    {
        string[] firstNames = { "Саша", "Маша", "Олег", "Света", "Игорь" };

        public override void Start()
        {
            Console.WriteLine("Массив:");

            OutArray();
            
            Console.WriteLine("\n"); 
            
            Array.Reverse(firstNames);

            Console.WriteLine("Реверс массива:");

            OutArray();

            Console.WriteLine("\n"); 
            
            Console.WriteLine("Массив с исключением всех элементов, кроме одного:"); 
            
            Array.Clear(firstNames, 1, 4);

            OutArray();

            Console.WriteLine();
        }

        void OutArray()
        {
            for (int i = 0; i < firstNames.Length; i++)
                Console.Write(firstNames[i] + "  ");
        }
    }
}

