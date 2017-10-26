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
            Double F, C;
            Console.WriteLine("podaj temp. w stopniach Farenheita");
            F = double.Parse(Console.ReadLine());
            C = 5d / 9 * (F - 32);
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}