using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock_and_Array
{
    class Program
    {
        public static void Ice(int[] tab, int m)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i+1; j < tab.Length; j++)
                {
                    if ((tab[i] + tab[j]) == m)
                    {
                        Console.WriteLine("poszukiwane indexy to " + i + " i " + j);
                    }                   
                       
                }
            }
            
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3,5,6,7,4 };
            Ice(tab, 9);
            Console.ReadKey();
        }
    }
}
