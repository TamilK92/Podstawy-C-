

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
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            if (numer == "1")
                Console.WriteLine("poniedziałek");
            else if (numer == "2")
                Console.WriteLine("wtorek");
            else if (numer == "3")
                Console.WriteLine("sroda");
            else if (numer == "4")
                Console.WriteLine("czwartek");
            else if (numer == "5")
                Console.WriteLine("piątek");
            else if (numer == "6")
                Console.WriteLine("sobota");
            else if (numer == "7")
                Console.WriteLine("niedziela");
            else
                Console.WriteLine("nie ma takiego dnia i huj");
            Console.ReadKey();
        }
    }
}