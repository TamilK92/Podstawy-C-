﻿

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
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            for (int i = uczestnicy.Length - 1; i >= 0; i--)
                Console.WriteLine(uczestnicy[i]);
            Console.ReadKey();
        }
    }
    }
