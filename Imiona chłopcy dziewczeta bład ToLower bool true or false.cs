using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formatowanie liczb:\n\t {0}, {0:c}, {0:p3}, {0:e3}, \n\t{0:f3}, {0:g1}, {0:n10}, {0:r}", 0.123456789);
            // {0:c} wynik w złotych, {0:p3} % i 3 miejsca po przecinku {0:e3} liczba e 3 miejsca {0:f3} 3 miejsca po przecinku
            //{0:g1} jedno miejsce po przecinku 
            Console.ReadKey();
        }
    }
}
