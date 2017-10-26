

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    class Program
    {
static string OpiszTyp()
{
return "Metoda bez argumentów";
}
static string OpiszTyp(int x)
{
return "Liczba całkowita";
}
static string OpiszTyp(string x)
{
return "Łańcuch znaków";
}
static string OpiszTyp(double x, int y)
{
return "Liczba double i liczba całkowita";
}
static void Main(string[] args)
{
    Console.WriteLine(OpiszTyp());
    Console.WriteLine(OpiszTyp(10));
    Console.WriteLine(OpiszTyp("Apollo 10"));
    Console.ReadKey();
        }
    }
}
