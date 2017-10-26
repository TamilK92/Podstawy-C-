

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
            Console.WriteLine("Podaj dodatni wykładnik");
            int wykladnik = Convert.ToInt16(Console.ReadLine());
            if (wykladnik > 0)
            {
                int potega = 1;
                for (int i = 1; i <= wykladnik; i++)
                {
                    potega = potega * 2;
                    Console.WriteLine("2 do {0} = {1}", i, potega);
                }
                Console.ReadKey();
            }
        }
    }
}