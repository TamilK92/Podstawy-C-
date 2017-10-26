using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            object o = i;
            Console.WriteLine(o.GetType().ToString()); // zwraca system.int32
            
            Console.ReadKey();
            }
        }

    }
