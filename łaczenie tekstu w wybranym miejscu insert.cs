

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
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
                Console.Write("{0,8}", rand.Next(1, 1000));
            Console.ReadKey();
        }
    }
    }
