using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugowanie
{
    class Program
    {
        static private int Kwadrat(int argument)
        {
            int wartość;
            wartość = argument * argument;
            if (wartość < 0)
                throw new Exception("Funkcja kwadratowa nie powinna zwracać wartości ujemnej");
            return wartość;
        }

        static void Main(string[] args)
        {
            try
            {
                int x = 1234;
                int y = Kwadrat(x);
                y = Kwadrat(y);
                string sy = y.ToString();
                Console.WriteLine(sy);
            }
            catch (Exception ex)
            {
                ConsoleColor bieżącyKolor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red; // zmienia kolor komunikatu na czerwony
                Console.WriteLine("Błąd: " + ex.Message); // wyświetla komunikat ex - Exception
                Console.ForegroundColor = bieżącyKolor;
            }
            Console.ReadKey();
        }
    }
}
