

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Reverse(tab);
            foreach (int x in tab)
                Console.Write("{0,2}", x);
            Console.ReadKey();
        }
    }
    }
