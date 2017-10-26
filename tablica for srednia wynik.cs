

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
           int [,] tablica_2d = {{1,2},{3,4},{5,6},{7,8}};
           foreach (int x in tablica_2d)
               Console.Write(x);
            Console.ReadKey();
        }
    }
    }
