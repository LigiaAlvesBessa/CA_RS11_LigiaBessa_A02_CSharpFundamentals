using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E14_ConversorDolarParaEuro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            double dolar, euro;
            Utility.WriteMessage("Intruduza o valor em dolares $: ");
            dolar = Convert.ToDouble(Console.ReadLine());

            euro = dolar * 1.1579;

            Utility.WriteMessage($"Convertendo {dolar}$ dá {euro}€");


            Utility.TerminateConsole();

        }
    }
}
