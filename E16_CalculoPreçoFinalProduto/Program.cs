using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E16_CalculoPreçoFinalProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            double precoBase, precoFinal; 
            Utility.WriteMessage("Indique o Preço Base do Produto: ");
            precoBase = Convert.ToSingle(Console.ReadLine());

            precoFinal = precoBase * 1.23;

            Utility.WriteMessage($"O preço final é de {precoFinal}", "\n\n", "");


            Utility.TerminateConsole();

        }
    }
}
