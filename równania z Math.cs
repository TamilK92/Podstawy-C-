//Sortowanie babelkowe
//www.algorytm.org

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sortowanie_babelkowe
{
    class Program
    {

        static void Main(string[] args)
        {
            double x = 0, y;
            Console.WriteLine("Działanie x++ ");
            y = x++ * 2;
            Console.WriteLine(x);
            Console.WriteLine(y);
            /* wynik to 1 i 0 czyli x zwikszył się o 1 po wykonaniu
             * działania i to robi ++ z tyłu*/
            Console.ReadKey();
        }
    }
}