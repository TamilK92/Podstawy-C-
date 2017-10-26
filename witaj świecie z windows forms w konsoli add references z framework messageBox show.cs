using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello1
{
    class Program
    {
        //Informacje o systemie metoda string opis pokolei + dodaje kolejne linijki/wartości
        static private string System = "Informacje o systemie:" // przy wywołaniu najpierw wyświetla ""Informacje o systemie"
            + "\nWersja systemu: " + Environment.OSVersion // wyświetla wersje systemu
            + (Environment.Is64BitOperatingSystem?", 64 bitowy":"") // jeżeli system 64 bitowy to dopisuje jeśli nie, nie dopisuje nic
            + "\nWersja Microsoft .NET Framework: " + Environment.Version //wyświetla wersje środowiska .NET
            + "\nNazwa komutera: " + Environment.MachineName // podaje nazwę komuptera
            + "\nKatalog systemowy: " + Environment.SystemDirectory; // pokauje gdzie znajduje sie katalog systemowy

        static void Main(string[] args)
        {
            Console.WriteLine("SystemIndo\n------\n");
            Console.WriteLine(System );
            Console.ReadKey();
        }
    }
}
