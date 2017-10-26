//Sortowanie babelkowe
//www.algorytm.org

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sortowanie_babelkowe
{
    class Program
    {

        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("y=Pierwiastek(|sin(x)|*log2(x)) \n");
            Console.WriteLine("Podaj x (wieksze od 0): ");
            x = Convert.ToDouble(Console.ReadLine()); // to co wrzucasz z klawki to pierwotnie string wiec to zamienia go na double
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0)); //Math to funkcje matematyczne Sqrt to pierwiastek Abs wartość bezwzględna Log logarytm (liczba logarytmwana, stopień algorytmu double z kropką)
            Console.WriteLine("\n y wynosi: ");
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}