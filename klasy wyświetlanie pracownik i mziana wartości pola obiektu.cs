using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    public class Pracownik
    {
        public static int liczbaPrac; // pole statyczne
        string Nazwisko { get; set; } // właściwość
        double Zarobki { get; set; } // właściwość
        public Pracownik(string naz, double zar) // konstruktor
        {
            liczbaPrac++;
            Nazwisko = naz;
            Zarobki = zar;
        }
        static Pracownik() //konstruktor statyczny
        {
            liczbaPrac = 0;
        }
        public void PokazPracownika() // metoda
        {
            Console.WriteLine("{0,-15} {1,10}", Nazwisko, Zarobki);
        }
        public static double Sumuj(Pracownik[] tab) // metoda statyczna
        {
            double suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma = suma + ab[i].Zarobki;
            }
            return suma;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba {0}", Pracownik.liczbaPrac);
            Pracownik p1 = new Pracownik("Kowalski", 1250.0);
            p1.PokazPracownika();
            Pracownik p2 = new Pracownik("Nowak", 1340.0);
            p2.PokazPracownika();
            //Pracownik p3 = new Pracownik();
            Console.WriteLine("Liczba {0}", Pracownik.liczbaPrac);
            Console.ReadKey();
        }
    }
}
