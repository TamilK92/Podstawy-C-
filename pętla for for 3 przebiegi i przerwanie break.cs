

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

            for (int j = 1; j <= 6; j++)
            {
                if (j == 4) 
                    continue;  // pomiń dalsze instukcje i wznów pętle
                Console.WriteLine(j);
            }
            Console.ReadKey();
            }
        }
    }