using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static private void zakresDouble(ref double min, ref double max)
        {
            min = double.MinValue; // podaje min wartośc double
            max = double.MaxValue; // podaje max wartośc double
            Console.WriteLine("Liczby double mogą nalezeć do przediząłu(" + min + "," + max + ")");
        }
        static void Main(string[] args)
        {
            double min = 0, max = 0;
            zakresDouble(ref min, ref max);
            Console.WriteLine("liczby double mogą należeć do przedziału("+min+","+max+")");
            Console.ReadKey();
        }
    }
}
