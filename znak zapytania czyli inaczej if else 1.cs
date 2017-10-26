

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
            int y, x = 1;
            //y = (x > 0) ? ++x : --x;
            if (x > 0)
                y = ++x;
            else
                y = --x;
                Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}