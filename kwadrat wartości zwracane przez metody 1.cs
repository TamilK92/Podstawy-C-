using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static private void zakresDouble(double min, double max)
        {
            min = double.MinValue;
            max = double.MaxValue;
            Console.WriteLine("Liczby double mogą nalezeć do przediząłu(" + min + "," + max + ")");
        }
        static void Main(string[] args)
        {
            double min = 0, max = 0;
            zakresDouble(min, max);
            Console.WriteLine("liczby double mogą należeć do przedziału("+min+","+max+")");
            Console.ReadKey();
        }
    }
}
