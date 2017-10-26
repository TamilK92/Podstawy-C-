

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
            int[] tablica = new int[3];
            Console.WriteLine("Podaj 1 element tablicy");
                tablica[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2 element tablicy");
                tablica[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj 3 element tablicy");
                tablica[2] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    if (i < 2)
                        Console.WriteLine(tablica[i] + ",");
                    else
                        Console.WriteLine(tablica[i]+".");
                }
                   
            Console.ReadKey();
        }
    }
}