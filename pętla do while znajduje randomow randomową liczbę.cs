using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten10
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;// pomijamy przypadki, gdy obie zmienne równe są 0
                    Console.WriteLine("i=" + i + ", j=" + j);
                }
            

            Console.ReadKey();
        }
    }
}
