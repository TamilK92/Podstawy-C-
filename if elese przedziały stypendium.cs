

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
            int uczestnik_1 = 19;
            int uczestnik_2 = 34;
            int uczestnik_3 = 23;
            int uczestnik_4 = 54;
            int uczestnik_5 = 31;
            double srednia = (uczestnik_1 + uczestnik_2 + uczestnik_3 + uczestnik_4 + uczestnik_5) / 5.0;
            Console.WriteLine(srednia);
            Console.ReadKey();
            }
        }
    }