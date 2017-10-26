

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
            Console.WriteLine("czas: {0}", DateTime.Now);
            Console.WriteLine("Ponownie pokazać aktualny czas (t/n)");
            string odpowiedz = Console.ReadLine();
            while (odpowiedz != "n")
            {
                Console.WriteLine("Czas: {0}", DateTime.Now);
                Console.WriteLine("Ponownie pokazać aktualny czas (t/n)");
                odpowiedz = Console.ReadLine();
            }
        }
    }
}