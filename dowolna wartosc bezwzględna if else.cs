

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
            int a;
            Console.WriteLine("Podaj liczbe której wartość bezwzględną chcesz poznać: \n");
            a = int.Parse(Console.ReadLine());

            if (a >= 0)
                Console.WriteLine("wartośc bezwzględna podanej liczby to: \n {0}", a);
            else
                Console.WriteLine("wartośc bezwzględna podanej liczby to: \n {0}", -a);
            Console.ReadKey();
        }
    }
}