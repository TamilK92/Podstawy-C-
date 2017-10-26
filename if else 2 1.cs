using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(8);
            string opis;
            Console.WriteLine(n);
            switch (n)
            {
                case 1: opis = "niedziela"; break;
                case 2: opis = "poniedziałek"; break;
                case 3: opis = "wtorek"; break;
                case 4: opis = "środa"; break;
                case 5: opis = "czwartek"; break;
                case 6: opis = "piątek"; break;
                case 7: opis = "sobota"; break;
                default: opis = "błąd!"; break;
            }
            Console.WriteLine("dzień tygodnia: " + n + ", " + opis);
            
            Console.ReadKey();
        }
    }
}
