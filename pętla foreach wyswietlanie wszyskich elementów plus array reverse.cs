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
            int[] losy = new int[16];
            Random r= new Random();
            for (int index = 0; index < losy.Length; index++)
                losy[index] = r.Next(100);

            Console.WriteLine("tablica przed sortowaniem: ");
            foreach (int x in losy)
                Console.Write(x + ", ");

            Array.Sort(losy);
            Console.WriteLine("\ntablica po sotowaniu: ");
            foreach (int x in losy)
                Console.Write(x + ", ");

            Console.ReadKey();
        }
    }
}
