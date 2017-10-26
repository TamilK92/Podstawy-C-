using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int y = 1 / x;
            }
            catch (Exception exc)
            {
                Console.ReadKey();
            }
        }
    }
}
