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
            for (int i = 0; i < 5; i++)
                Console.WriteLine(uczestnicy[i]);
            Console.ReadKey();
        }
    }
}