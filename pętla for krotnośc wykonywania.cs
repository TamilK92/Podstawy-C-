﻿

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
            for (int i = 1; i <= 5; i++)
                for (int j = 1; j <= 5; j++)
                    Console.WriteLine("i = {0}, j = {1}", i, j);
            Console.ReadKey();
        }
    }
}