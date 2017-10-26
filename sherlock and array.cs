using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flaga_polski
{
    class Program
    {
        public static int Silnia(int n)
        {
            string s = "hwdp";
            if (n <= 0)
            {
                Console.WriteLine(s);
                return 0;
        }
            if (n ==1) return 1;
            else
                 return n * Silnia(n - 1);
            
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("podaj silnie jakiej liczby chesz uzyskać");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("silnia " + n + " to " + Silnia(n));
                Console.ReadKey();
            }
        }          
    }
