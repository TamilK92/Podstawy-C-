using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

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
        static private string Użytkownik = "Informacje o bieżącym użytkowniku:"
            + "\nNazwa użytkownika " + Environment.UserName
            + "\nKatalogi specjalne użytkownika:"
            + "\nkatalog 'Moje dokumenty' = " + Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            + "\nKatalog 'Pulpit' = " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            + "\nKatalog 'moje obrazy' = " + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            + "\nKatalog 'menu start' = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
            + "\nKtalog programy' = " + Environment.GetFolderPath(Environment.SpecialFolder.Programs)
            + "\nKatalog ' autostart' = " + Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            + "\nKatalog domowy użytkownika = " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        static void Main(string[] args)
        {
            Console.WriteLine("SystemIndo\n------\n");
            Console.WriteLine(System + "\n"); // + "\n" na samym koncu przesówa kursor linie niżej niż wyświetlone informacje
            Console.WriteLine(Użytkownik + "\n");
            Console.ReadKey();
        }
    }
}
