

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
            for (int i = 1; i < 10; i++) 
                /* for rozpoczyna pętle int i = 1, zmienna i jest licznikiem
                 * pętli czyli od czego zaczyna liczyć tutaj ma wartośc =1
                 * i < 10 to wyrażenie logiczne jezeli jest true pętla się 
                 * wykona jeżeli flase nastąpi zakończenie działania pętli
                 * ostatnie i++ to opracja zwiększajaca wartośc i o 1 za
                 * każdym razem kiedy wykona się petla i++można inaczej 
                 * zapisać jako i = i+1
                 */
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}