using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting_sort
{
    class Program
    {
        public static int[] CountingSort(int[] tab, int max)
        {
            int index = 0;
            int[] counttab = new int[max+1];
            for (int i = 0; i < tab.Length; i++)
                counttab[tab[i]]++;
               for (int j = 0; j < counttab.Length; j++)
                {
                    while (counttab[j] != 0)
                    {
                        tab[index++] = j;
                        counttab[j]--;
                    }
                }
            return tab;
            }

        static void Main(string[] args)
        {
            int[] tab = { 6, 23, 12, 33, 0, 4, 5, 23, 12, 100, 23, 4, 2, 0 };
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
            Console.WriteLine();
            CountingSort(tab, 100);
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
            Console.ReadKey();

        }
    }
}
