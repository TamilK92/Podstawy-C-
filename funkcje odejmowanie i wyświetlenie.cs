

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {
        static double Dziel(double x, int y)
        {
            return (x / y); // zakładamy, że y jest różne od zera
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dziel(1.5, 3)); // wywołanie metody
            Console.ReadKey();
        }
    }
    }
