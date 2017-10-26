

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] tab = { 4, 2, 6, 23, 1, 3, 7, 0 };
            Array.Sort(tab); // sortowanie tablicy
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i]+ " ");
            Console.ReadKey();
        }
    }
    }
