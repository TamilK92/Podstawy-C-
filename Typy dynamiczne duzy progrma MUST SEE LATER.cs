using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Klasa
    {
        public delegate void Callback(object sender, DateTime czasZakończeniaMetody);

        public Callback DelegacjaMetodaZakończona;
        public event Callback ZdarzenieMetodaZakończona;

        public void Metoda()
        {
            Console.WriteLine("metoda - początek");
            //tu długie działanie metody
            Console.WriteLine("Metoda - tuż przed końcem");
            if (DelegacjaMetodaZakończona != null)
                DelegacjaMetodaZakończona(this, DateTime.Now);
            if (DelegacjaMetodaZakończona != null)
                DelegacjaMetodaZakończona(this, DateTime.Now);

            Console.WriteLine("Metoda - koniec");
        }
    }

    class Program
    {
        static dynamic obiekt = 1; // pole zainicjowane obiektem typu int

        enum Typ { Int, Long, String, Float, Double, DivideByZeroException, Pole, InstancjaKlasy };

        dynamic Obiekt //własnośc
        {
            get
            {
                return zwrocObiekt();
            }
            set
            {
                obiekt = value;
            }
        }

        static dynamic zwrocObiekt(Typ ktoryTyp = Typ.Int) //wartosc zwtracana przez metode
        {
            dynamic wartosc;
            switch (ktoryTyp)
            {
                case Typ.Int: wartosc = 5; break;
                case Typ.Long: wartosc = 5L; break;
                case Typ.Float: wartosc = 1.0f; break;
                case Typ.Double: wartosc = 1.0; break;
                case Typ.DivideByZeroException: wartosc = new DivideByZeroException(); break;
                case Typ.Pole: wartosc = obiekt; break;
                case Typ.InstancjaKlasy: wartosc = new Klasa(); break;
                default: wartosc = null; break;
            }
            return wartosc;
        }

        static void Main(string[] args)
        {
            for (Typ typ = Typ.Int; typ <= Typ.InstancjaKlasy; typ++)
            {
                try
                {
                    dynamic o = zwrocObiekt(typ);
                    Console.WriteLine("Obiekt: " + o.String() + ", tp: " + o.GetType().FullName);
                    o.Metoda();//tu pojawi sie wyjątek
                }
                catch (Exception exc)
                {
                    ConsoleColor biezacyKolor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błąd: " + exc.Message);
                    Console.ForegroundColor = biezacyKolor;
            }
            Console.ReadKey();
            }
        }

    }
}
