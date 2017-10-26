

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
           int rozmiar;
               Console.WriteLine("Ile imion chesz wpisaC");
               rozmiar = int.Parse(Console.ReadLine());
            string[] tab = new string[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj imie nr {0}", i+1);
                tab[i] = Console.ReadLine();
        }
            for(int k =0; k<tab.Length; k++)
            Console.Write(tab[k]+", ");
            Console.ReadKey();
        }
    }
    }
