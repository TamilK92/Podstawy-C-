using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<int> li = new Lazy<int>(() => 1); //deklaracja zmiennej i wskazanie funkcji
            Console.WriteLine(li.IsValueCreated.ToString()); // jeszcze niezainicjalizowana
            Console.WriteLine("Odwołanie do zmiennej, li=" + li.Value); //leniwa inicjacja
            Console.WriteLine(li.IsValueCreated.ToString()); //już zainicjjowana

            Console.ReadKey();
        }
    }
}
