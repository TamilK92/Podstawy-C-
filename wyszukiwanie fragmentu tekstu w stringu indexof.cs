

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
            string tekst = "Ala ma kota";
            string nowy_tekst;
            nowy_tekst = tekst.Insert(7, "kanarka i ");
            Console.WriteLine(nowy_tekst);
            Console.ReadKey();
        }
    }
    }
