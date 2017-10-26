

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trajning
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Liczby w {0} wierszu:", i);
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 3) break;
                    Console.Write(j + ",");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            }
        }
    }