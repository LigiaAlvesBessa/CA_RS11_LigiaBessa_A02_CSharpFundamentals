using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E15_ConversorFahrenheitParaCelsius
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            float f; 
            Utility.WriteMessage("Indique a temperatura em Farenheit: ");
            f = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("{0}ºF = {1:F2}ºC", f, 5 / 9 * (f - 32));

            Utility.TerminateConsole();

        }
    }
}
