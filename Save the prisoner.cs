using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace save_the_prisoner
{
    class Program
    {
        public static int SavePrisoner(int [] tab, int cukierki)
        {
            Random r = new Random();
            int wynik = r.Next(tab.Length) + cukierki;
            if (wynik <= cukierki)
                Console.WriteLine("uratuj więźnia index " + wynik);
            else
            {
                while(wynik >= tab.Length)
                {
                    wynik -= tab.Length;
                }

            }
            Console.WriteLine("c " + cukierki);
            Console.WriteLine("uratuj więźnia index " + wynik);
            return wynik;
         }
        static void Main(string[] args)
        {
            Random r = new Random();
            int wynik = r.Next(100);
            int[] tab = new int[30];
            SavePrisoner(tab, wynik);
            Console.ReadKey();
        }
    }
}
