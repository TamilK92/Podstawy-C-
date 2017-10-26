using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new DivideByZeroException();
            if (o is DivideByZeroException)
                Console.WriteLine("Obiekt jest wyjątkiem dzielenia przez zero");
            else
                Console.WriteLine("obiekt nie jest wyjątkiem");
            Console.WriteLine(o.GetType().FullName);
            Console.ReadKey();
        }
    }
}
