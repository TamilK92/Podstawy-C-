using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(8);
            //zadanie komputera to odagadnąć 
        // liczbę z zakrestu od 0 do 8
            int z, licznik = 0;
            do
            {
                licznik++;
                z = r.Next(8);
            }
            while (n != z);
            Console.WriteLine("Komputer zgadł licznę "+ z + " po " + licznik + " próbach");
            Console.ReadKey();
        }
    }
}
