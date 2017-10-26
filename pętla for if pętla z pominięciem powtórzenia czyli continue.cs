

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trajning
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("wprowadz liczbę całkowita\n");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba % 2 == 0)
                Console.WriteLine("{0} jest liczbą parzystą", liczba);
            else
                Console.WriteLine("{0} jest liczną nieparzystą", liczba);
            if (liczba < 0)
                Console.WriteLine("{0} jest liczną ujemną", liczba);
            else
                Console.WriteLine("{0} nie jest liczną ujemną", liczba);
            Console.ReadKey();
            }
        }
    }