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
            int x = 1, y = 2, z = 3;
            bool wynik;
            wynik = (x == 1 | y != 5 && z < 1);
            Console.WriteLine(wynik);
            Console.ReadKey();
/*Podobnie jak w matematyce operatory arytmetyczne i logiczne podporzadkowane 
 * są pewnym regułom. Reguły te związane są m.in. z piorytetami operatorów.
 * Priorytety operatorów decydują o kolejności wartościowania argumentów
 * Operator koniunkcji (&& oraz &) ma wyższy priorytet niż operator alternatywny
 * (|| i |). Podobnie jak w matematyce operator mnozenia ma wyższy piorytet niż 
 * dodawania.*/
        }
    }
}