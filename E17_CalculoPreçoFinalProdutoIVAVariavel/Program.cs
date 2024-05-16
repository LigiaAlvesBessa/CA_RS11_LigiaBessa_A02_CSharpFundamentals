using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E17_CalculoPreçoFinalProdutoIVAVariavel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            float precoBase, valorIVA;
            Utility.WriteMessage("Indique o Preço Base do Produto: ");
            precoBase = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Indique a Taxa de IVA 0,06, 0,13 ou 0,23: ");
            valorIVA = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("PVP = {0:F2}€", precoBase * (1+valorIVA));


            Utility.TerminateConsole();

        }
    }
}
