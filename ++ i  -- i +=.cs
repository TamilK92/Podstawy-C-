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
            int x, y = 5; // x nie ma jeszcze wartości y=5
            x = ++y;
            x = y++;
            x = --y;
            x = y--;
            Console.WriteLine(y++);
            Console.ReadKey();
        }
    }
}