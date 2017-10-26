

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
            int wynik;
            string tekst1 = "Kowalskdfi";
            string tekst2 = "Nowak";
            wynik = String.Compare(tekst1, tekst2); // wypisze -1
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
    }
