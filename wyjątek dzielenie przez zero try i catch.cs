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
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("dzielenie przez zero: " + exc.Message);
                Console.ReadKey();
                return;
            }
            catch (ArithmeticException exc)
            {
                Console.WriteLine("Bład arytmetyki: " + exc.Message);
                Console.ReadKey();
                return;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Wyjątek: " + exc.Message);
                Console.ReadKey();
                return;
            }
            finally
            {
                Console.WriteLine("Kod wykonywany  kazdym prypadku");
            }
            Console.ReadKey();
        }
    }
}
