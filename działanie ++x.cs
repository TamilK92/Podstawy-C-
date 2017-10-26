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
            int x, y = 4; // x nie ma jeszcze wartości y=4
            Console.WriteLine("Działanie ++ i -- i +=");
            x = (y += 3); //Zmienna y zwieksza sie o 3 więc x=7
            x = ++y; // y zwiększa się o 1 więc x=8
            x = y--; // teraz najpierw x pozostaje =8 a y dopiero potem zmienjsza się o 1 czyli y=7
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}