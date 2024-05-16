using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E11_ApresentarUmNumeroInteiroDeUmNumeroPedidoAoUtilizador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            float a;
            Utility.WriteMessage("Intruduza um número: ");
            a = Convert.ToSingle(Console.ReadLine());

            //Foi utilizada uma conversão de tipo (Type Cast)
            Console.WriteLine("A parte inteira de {0} é {1}.", a, (int)a);

            Utility.TerminateConsole();

        }
    }
}
