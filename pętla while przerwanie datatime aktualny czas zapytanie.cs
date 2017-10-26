

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
            string odpowiedz;
            do
            {
                Console.WriteLine("czas: {0}", DateTime.Now);
                Console.WriteLine("ponownie pokazać aktualny czas? (t/n)");
                odpowiedz = Console.ReadLine();
            } while (odpowiedz != "n");
        }
    }
}