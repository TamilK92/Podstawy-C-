

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
            double cena = 0.0;
            Console.WriteLine("Podaj porcję (S / M / L)");
            string porcja = Console.ReadLine();
            switch (porcja)
            {
                case "S":
                    cena += 4.5;
                    break;
                case "M":
                    cena += 2.0;
                    goto case "S";
                case "L":
                    cena += 3.0;
                    goto case "S";
                default:
                    Console.WriteLine("podna zły symbol");
                    break;
            }
            Console.WriteLine("Cena = {0}", cena);
            Console.ReadKey();
        }
    }
}