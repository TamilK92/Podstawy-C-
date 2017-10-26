using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flaga_polski
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int suma1 = 0;
            int suma2 = 0;            
           // int suma3;
           // int[] tab = { 1,2,3,4,5,1,8,6};
            int licznik = 0;
            int n = 0;
            int [] tab = new int[16];
            Random r = new Random();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = r.Next(30);
            //nadane wartości*/
            //int[] sumatab1;
            for(int j = 0; j<tab.Length; j++)
            {
                int[] sumatab1= new int [j+1];
                //int[] sumatab2= new int [j+1];
                suma1 = suma1 + tab[j];
               // suma2 = suma2 + tab[tab.Length - 1 - j];
               // sumatab2[j] = suma2;
                sumatab1[j] = suma1;
               // for (int q = 0; q < tab.Length; q++)
               // {
                   /* if (suma1 != suma2)
                    {
                        Console.WriteLine("huj");
                    }
                    else
                        Console.WriteLine("git");

              //  }
                
               /* Console.WriteLine("tablica suma1 nr "+ j);
                for (int i = 0; i < sumatab1.Length; i++)
                {
                    Console.Write(sumatab1[i] + " ");
                }
                Console.WriteLine("\ntablica suma2 nr "+ j);
                for (int z = 0; z < sumatab2.Length; z++)
                {
                    Console.Write(sumatab2[z] + " ");
                }*/
                Console.WriteLine(suma1);
                suma2 = suma2 + tab[tab.Length - 1 - j];
                for (int k = 0; k < sumatab1.Length; k++)
                {
                    if (sumatab1[k] == suma2)
                        licznik++;
                    
                    
                }
                /*Console.WriteLine(suma2);
                Console.WriteLine("j równa sie="+j+"\n");*/
               
            }
            if (licznik != 0)
                Console.WriteLine("YES " + licznik);
            else
                Console.WriteLine("NO");

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
                Console.ReadKey();
            }
        }          
    }
