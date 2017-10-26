using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shitshit
{
    class Klasa
    {
        public delegate void Callback(object sender, DateTime czasZakończeniaMetody);

        public Callback DelegacjaMetoadaZakończona;
        public event Callback ZdarzenieMetodaZakończona;

        public void Metoda()
        {
            Console.WriteLine("Metoda - początek");
            //tu długie działanie metody
            Console.WriteLine("Metoda - tuż przed końcem");

            if (DelegacjaMetoadaZakończona != null)
                DelegacjaMetoadaZakończona(this, DateTime.Now);
            if (ZdarzenieMetodaZakończona != null)
                ZdarzenieMetodaZakończona(this, DateTime.Now);
            Console.WriteLine("Metoda - koniec");
        }
    }
    class Program
    {
        static private void obiekt_MetodaZakończona(object sender, DateTime czasZakoncznieaMetody)
        {
            Console.WriteLine("Zakonczona metoda obiektu typu " + sender.GetType().Name + " (czas: " + czasZakoncznieaMetody.ToString() + ")");
        }
        static void Main(string[] args)
        {
            Klasa obiekt = new Klasa();

            //subskrybcja
            obiekt.DelegacjaMetoadaZakończona = obiekt_MetodaZakończona;
            obiekt.ZdarzenieMetodaZakończona += obiekt_MetodaZakończona;//uruchomienie metody, która wywołała metodę zdarzeniową
            obiekt.Metoda();
            Console.ReadKey();
        }
    }
}
