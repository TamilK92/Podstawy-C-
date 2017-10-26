using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Program
    {
        static void Metoda() //głowa metody, sygnatura
        {
            Console.WriteLine("hello skurwysynu!");
        }
        static void Metoda(string tekst)
        {
            Console.WriteLine(tekst);
        }
        static void Metoda(string tekst, ConsoleColor kolor = ConsoleColor.White)
        {
            ConsoleColor bieżącyKolor = Console.ForegroundColor;
            Console.ForegroundColor = kolor;
            Console.WriteLine(tekst);
            Console.ForegroundColor = bieżącyKolor;
        }
        static void Main(string[] args)
        {
            Metoda(); // wywołanie metody
            Metoda("witaj kurwiu!");
            Metoda("HWDP", ConsoleColor.Green);
            /* Język C# umożliwia definiowanie wielu metod o tych damych nazwach, pod 
             * warunkiem ze różnią sie parametrami (dzięki temu mają również inne sygnatury)
             * Nazywa się to przeciązeniem metodg (ang. overload). Niemożliwe jest natomiast definiowanie
             * dwóch metodo różniących sie jedynie zwracanymi Wartościami.*/
            Console.ReadKey();
        }
    }
}
