using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{   
    class Program
    {
        delegate int DInc(int n);
        delegate bool DIsEqual(double x, double y);
        delegate void DShow(int n);

        static void Main(string[] args)
        {
            Console.WriteLine("Wyrażenia Lambda:\n");

            DInc Inc = (int n) => n + 1;
            Console.WriteLine("Inc(1)=" + Inc(1));

            DIsEqual IsEqual = (x, y) => x == y;
            int a = 10;
            int b = 20;

            Console.WriteLine("czy równe a=" + a + " i b=" + b + "?" + (IsEqual(a, b) ? "Tak" : "Nie"));
            Console.WriteLine("czy równe a=" + a + " i b=" + b + "?" + (IsEqual(a, b) ? "Tak" : "Nie"));

            DShow Show = n => { Console.WriteLine(n.ToString()); };
            Show(10);
            Console.ReadKey();
        }
    }
}
