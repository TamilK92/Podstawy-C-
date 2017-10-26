using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten10
{
    class Program
    {
        public static long największydzielnik(long args)
            {
               long dzielnik = args -1;
            while (args%dzielnik!=0)
                dzielnik--;
            return dzielnik;              
            }
        static void Main(string[] args)
        {
           
            Console.WriteLine(największydzielnik(500314));
            
            Console.ReadKey();
        }
    }
}
