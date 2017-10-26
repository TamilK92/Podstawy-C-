

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
            double przychod, koszta;
            Console.WriteLine("podaj przychod: \n");
            przychod = double.Parse(Console.ReadLine());
            Console.WriteLine("\npodaj koszta: \n");
            koszta = double.Parse(Console.ReadLine());
            double dochod = przychod - koszta;
            if (dochod != 0)
            {
                if (dochod > 0)
                    Console.WriteLine("mamy zysk");
                else
                    Console.WriteLine("mamy stratę");
            }
            else
            {
                    Console.WriteLine("mamy zdochód zerowy");
            }
            Console.ReadKey();
        }
    }
}