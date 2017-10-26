

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {
        static int Daj(int x = 0) // argument domyślny
        {
            return x;
        }
        static int Daj()
        {
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Daj(int x));
            Console.ReadKey();
        }
    }
}
