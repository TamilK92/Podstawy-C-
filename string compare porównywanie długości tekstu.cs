

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
            string tekst_zlaczony;
            string tekst1 = "Ala ma kota";
            string tekst2 = " i psa";
            tekst_zlaczony = string.Concat(tekst1, tekst2);
            Console.WriteLine(tekst_zlaczony);
            Console.ReadKey();
        }
    }
    }
