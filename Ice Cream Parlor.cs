using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_Array
{
    class Program
    {
        public static int[] Insert(int[] tab, int m)
        {
            int [] array= new int [tab.Length+1];
            
            for(int i = 0; i<array.Length;i++)
            {
                if (tab[i] < m)
                {
                    array[i] = tab[i];
                }
                else
                {
                    array[i] = m;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        array[j] = tab[i];
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
            Insert(tab,7);
            foreach (int x in tab)
            {
                Console.Write(tab[x] + " ");
            }
            Console.ReadKey();
        }
    }
}
