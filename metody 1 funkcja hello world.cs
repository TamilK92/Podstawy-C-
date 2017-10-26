using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static void Metoda() //głowa metody, sygnatura
        {
            Console.WriteLine("hello skurwysynu!");
        }
        static void Metoda(string tekst)
        {
            Console.WriteLine(tekst);
        }
        static void Main(string[] args)
        {
            Metoda(); // wywołanie metody
            Metoda("witaj kurwiu!");
            Console.ReadKey();
        }
    }
}
