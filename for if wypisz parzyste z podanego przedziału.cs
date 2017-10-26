

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
            Console.WriteLine("Wprowadz liczbę 1");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz liczbę 2");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.Write("Liczby parzyste: ");
            liczba1 = (liczba1 % 2 == 0) ? liczba1 : liczba1 + 1;
            liczba2 = (liczba2 % 2 == 0) ? liczba2 : liczba2 - 1;
            for (int i = liczba1; i <= liczba2; i = i + 2)
            {
                    Console.Write(i + ",");
            }
            Console.ReadKey();
            }
        }
    }