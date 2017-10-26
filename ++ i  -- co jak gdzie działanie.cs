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
            double wiek, PLN;
            bool kino;
            Console.WriteLine("podaj wiek: ");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniędzy: ");
            PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20); /* && oznacza koniunkcję 
                                               * warunkową czyli jeżeli 
                                               * warunki z nawiasu będa 
                                               * oba spełnione wypluje 
                                               * true jeżeli chodz jeden nie
                                               * wypluje false */
            Console.WriteLine(kino);
            Console.ReadKey();
        }
    }
}