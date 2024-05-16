using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E13_MediaAritmetrica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            int a, b;
            Utility.WriteMessage("Intruduza um número inteiro: ");
            a = Convert.ToInt16(Console.ReadLine());

            Utility.WriteMessage("Intruduza um número inteiro: ");
            b = Convert.ToInt16(Console.ReadLine());

            double mediaAritmetrica;
            mediaAritmetrica = (a + b) / 2;
            Utility.WriteMessage($"A média aritmetrica de {a} e {b} é de {mediaAritmetrica}");


            Utility.TerminateConsole();

        }
    }
}
