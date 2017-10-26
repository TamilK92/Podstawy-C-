using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            /*aby to poniżej zdziała,la trzeba PROJECT/ADD REFERENCE/i zzaznaczyć po lewo System.Windows.Forms
             * i przed name space dodać using System.Windows.Forms;
             */
                System.Windows.Forms.MessageBox.Show("Witaj świecie");
            Console.ReadKey();
        }
    }
}
