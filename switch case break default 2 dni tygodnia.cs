using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten10
{
    class Program
    {
        public static long silnia(byte args)
            {
                if(args==0) return 0;
                long wartosc=1;
                for(byte i=1;i<=args;i++)
                    wartosc*=i;
                return wartosc;
              
            }
        static void Main(string[] args)
        {
           
            Console.WriteLine(silnia(5));
            
            Console.ReadKey();
        }
    }
}
