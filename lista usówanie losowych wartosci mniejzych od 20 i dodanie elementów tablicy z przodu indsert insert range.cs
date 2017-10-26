using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbles
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> artysci = new SortedList<string, string>();
            artysci.Add("Stoing", "Gordon Mathew Sumner");
            artysci.Add("BOlesław Prus", "Aleksander Głowacki");
            artysci.Add("Pola Negri", "Barbara Apolonia Chałupiec");
            artysci.Add("John Wayne", "Marion Michale Morrison");
            artysci.Add("Chico", "Leonard Marx");
            artysci.Add("Harpo", "Arthur Marx");
            artysci.Add("Groucho", "Julius Marx");
            artysci.Add("Bono", "Paul Hewson");
            artysci.Add("Ronaldo", "Luiz Nazario de Lima");
            artysci.Add("Madonna", "Madona Louise Veronica Ciccone");
            artysci.Add("Gabriela Zapolska", "Maria G. Śniezko-Błocka");

                string kominikat = "Zawartość listy:\n";
            foreach (KeyValuePair<string,string> artysa in artysci)
                kominikat += artysa.Key + " - " + artysa.Value + "\n";
            Console.WriteLine(kominikat);

            Console.ReadKey();
        }
    }
}
