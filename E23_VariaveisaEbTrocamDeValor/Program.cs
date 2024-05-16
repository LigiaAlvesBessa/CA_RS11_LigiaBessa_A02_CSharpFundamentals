using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E23_VariaveisaEbTrocamDeValor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            int a = 4, b = 5;
            Console.WriteLine("a:{0}\tb:{1}", a, b);

            
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a:{0}\tb:{1}", a, b);


            Utility.TerminateConsole();

        }
    }
}
