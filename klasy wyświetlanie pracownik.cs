

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shit
{
    public class Pracownik
    {
        public string nazwisko;
        private double zarobki;
        public Pracownik(string n, double z) // konstruktor
        {
            nazwisko = n;
            zarobki = z;
        }
        public void PokazPracownika() // metoda
        {
            Console.WriteLine("{0,-15} {1,10}", nazwisko, zarobki);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Kowalski", 1000);
            p1.nazwisko = "Nowak"; // zmiana wartości pola obiektu
            p1.PokazPracownika();
            Console.ReadKey();
        }
    }
}
