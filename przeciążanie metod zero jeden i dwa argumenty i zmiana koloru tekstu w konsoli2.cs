using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static private int Kwadrat(int arg)
        {
            return arg * arg;
        }
        static void Main(string[] args)
        {
            int wynik = Kwadrat(2);
            Console.WriteLine(wynik); // lub Console.WrtieLine(wynik.ToString());
            
            Console.ReadKey();
        }
    }
}
