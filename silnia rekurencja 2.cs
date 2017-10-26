using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flaga_polski
{
    class Program
    {
        public static int Fibo(int n)
        {
            int fibo;
            if (n == 0) return 0;
            if ((n ==1) || (n==2)) return 1;
            else return Fibo(n-1)+Fibo(n-2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("podaj ilu liczb chesz dostac fibo");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibo " + (n-1) + " liczb to " + Fibo(n));
                
                Console.ReadKey();
            }
        }          
    }
