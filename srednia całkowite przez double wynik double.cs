

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
            Console.WriteLine("Podaj liczbę:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n + i - 1; j++)
                    if (j == i)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                Console.WriteLine();               
            }
            Console.ReadKey();
        }
    }
}