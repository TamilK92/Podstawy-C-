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
            int rozmiar = 30;
            Random r = new Random();
            List<int> l = new List<int>(new int [rozmiar]);
            for (int i = 0; i < rozmiar; i++)
                l[i] = r.Next(100);
            l.AddRange(new int[10]);
            int[] i5 = { -1, -1, -1, -1, -1 };
            l.InsertRange(rozmiar, i5);
            l.Insert(0,1);

           
            for(int i = 0; i<l.Count; i++)
            {
                if(l[i]>20)
                {
                    l.RemoveAt(i);
                    i--;
                    }
                }
            l.Sort();

            string s = "Elementy listy: ";
            foreach(object ai in l)
                s += ai.ToString() + " ";
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
