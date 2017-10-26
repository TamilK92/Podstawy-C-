using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyszukiwanie_binarne
{
    class Program
    {
        public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
          Console.WriteLine(mid+" key mniejszy");
                    max = mid - 1;
                }
                else
                {
          Console.WriteLine(mid + " key wiekszy");
                    min = mid + 1;
                }
            }
            return "Nil";
        }
       public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
           
            if (min > max)
            {
                return "ssij";
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    Console.WriteLine(mid+" key mniejszy");
     
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    Console.WriteLine(mid + " key wiekszy");
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
               
            }

        }
        static void Main(string[] args)
        {            
            int[] tab = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("iteracja");
          Console.WriteLine( BinarySearchIterative(tab,1,0,tab.Length));
          Console.WriteLine("rekurencja");
            Console.WriteLine(BinarySearchRecursive(tab,1,0,tab.Length));

            Console.ReadKey();
        }
    }
}
