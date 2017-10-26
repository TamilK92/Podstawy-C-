

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
            int[] a = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            int[] b = new int[10];
            Array.Copy(a, 2, b, 3, 5);
            /* kopiuje od indexu 2 z tabeli a do tablicy b zaczynając od 3 
             * miejsca
             * */
            foreach (int x in b)
            {
                Console.Write("{0}, ", x);
            }
            Console.ReadKey();
        }
    }
    }
