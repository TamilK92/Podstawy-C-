

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trajning
{
    class Program
    {

        static void Main(string[] args)
        {          
            Console.WriteLine("Podaj średnią");
            double n = double.Parse(Console.ReadLine());

            if (n <= 3.99)
                Console.WriteLine("Kwota stypendium to 0 zł");
            else
            {
                if (n <= 4.79)
                Console.WriteLine("Kwota stypendium to 350 zł");
                else
                {                  
                        Console.WriteLine("Kwota stypendium to 550 zł");
                }
            }



            Console.ReadKey();
            }
        }
    }