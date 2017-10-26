

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {
        static void Dodaj(ref int a)
{
a++;
Console.WriteLine("Argument z wnętrza metody: " + a);
}
static void Main(string[] args)
{
int x = 5;
Console.WriteLine("Przed wywołaniem metody: " + x);
Dodaj(ref x);
Console.WriteLine("Powywołaniu metody: " + x);
Console.ReadKey();
        }
    }
    }
