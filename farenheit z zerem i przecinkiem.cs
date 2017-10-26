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
            const int komputery = 24;
            int studenci;
            double wynik;
            Console.WriteLine("Podaj Liczbę studentów: \n");
            studenci = Convert.ToInt32(Console.ReadLine());
            wynik = (double)studenci / komputery;
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}