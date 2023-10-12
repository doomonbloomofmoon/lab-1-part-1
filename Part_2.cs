using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_1
{
    internal class Part_2 : Part
    {
        string[] names = { "Костя", "Лена", "Миша" };

        int[] numbers = { 174, 706, 734, 669, 864, 203 };

        public override void Start()
        {
            PrintAr("Имена", names);
            PrintAr("Случайные числа", numbers);
        }

        void PrintAr(string name, Array A)
        {
            switch (A.Rank)
            {
                case 1:

                    for (int i = 0; i < A.GetLength(0); i++)
                        Console.WriteLine(name + "[{0}]={1}", i, A.GetValue(i));

                    Console.WriteLine();

                    break;

                case 2:

                    for (int i = 0; i < A.GetLength(0); i++)
                    {
                        for (int j = 0; j < A.GetLength(1); j++)
                            Console.Write(name + "[{0},{1}]={2}", i, j, A.GetValue(i, j));
                        
                        Console.WriteLine();
                    }

                    break;

                default: 
                    
                    break;
            }
        }
    }
}

