

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
            int[] uczestnicy = new int[] { 19, 34, 23, 54, 31 };
            int suma = 0;
            double srednial = 0;
                
                for (int i = 0; i < uczestnicy.Length; i++)
                {
                    srednial = srednial + uczestnicy[i];
                }
                Console.WriteLine("wiek uczestników: {0} ", srednial / uczestnicy.Length);
            Console.ReadKey();
        }
    }
    }
