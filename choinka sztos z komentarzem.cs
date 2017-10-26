using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trajninnng
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = {0,0,0,0,1,0,1,0,1,0,0,0,1,0,1,0,0,1,0,0,1,0,1,0,0,1,0,0};
            
            int n = 2;
            int i = 0;
            while (n < tab.Length)
            {
                if (tab[n] == tab[n - 2])
                    n += 2;
                else
                    n++;
                i++;
            }
            for (int j = 0; j < tab.Length; j++)
            {
                Console.Write(tab[j] + " ");
            }
            Console.WriteLine("\ntą trase można przejść w "+i+" krokach");
            Console.ReadKey();
        }
    }
}