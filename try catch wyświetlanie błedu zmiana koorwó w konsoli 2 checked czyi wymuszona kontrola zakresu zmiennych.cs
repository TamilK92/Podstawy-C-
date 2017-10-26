using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugowanie
{
    class Program
    {
        static private long Kwadrat(long argument)
        {
            long wartość;
            wartość = checked(argument * argument);
            if (wartość < 0)
                throw new Exception("Funkcja kwadratowa nie powinna zwracać wartości ujemnej");
            return wartość;
        }

        static void Main(string[] args)
        {
            try
            {
                long x = 1234;
                long y = Kwadrat(x);
                y = Kwadrat(y);
                string sy = y.ToString();
                Console.WriteLine(sy);
            }
            catch (Exception ex)
            {
                ConsoleColor bieżącyKolor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red; // zmienia kolor komunikatu na czerwony
                Console.Error.WriteLine("Błąd: " + ex.Message); // wyświetla komunikat ex - Exception
                Console.ForegroundColor = bieżącyKolor;
            }
            Console.ReadKey();
        }
    }
}
