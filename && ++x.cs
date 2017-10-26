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
            int x = 3, y = 10;
            bool wynik;
            wynik = (x >= 2 || y++ >= 2);
            Console.WriteLine(wynik);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
            // wynik to true x=3 y=10 (y nie jest sprawdzany bo x gra
        }
    }
}