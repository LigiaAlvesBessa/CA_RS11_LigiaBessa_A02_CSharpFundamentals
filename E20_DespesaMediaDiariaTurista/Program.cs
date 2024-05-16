using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E20_DespesaMediaDiariaTurista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            double despesaDia01, despesaDia02, despesaDia03, despesaDia04, mediaDespesaTotal;
            Utility.WriteMessage("Indique o valor gasto no 1º dia da viagrm: ");
            despesaDia01 = Convert.ToDouble(Console.ReadLine());

            despesaDia02 = despesaDia01 * 1.20;
            despesaDia03 = despesaDia02 * 1.20;
            despesaDia04 = despesaDia03 * 1.20;

            mediaDespesaTotal = (despesaDia01 + despesaDia02 + despesaDia03 + despesaDia04) / 4;

            Utility.WriteMessage($"\nNo 1º dia foi gasto {Math.Round(despesaDia01)}€.");
            Utility.WriteMessage($"\nNo 2º dia foi gasto {Math.Round(despesaDia02)}€.");
            Utility.WriteMessage($"\nNo 3º dia foi gasto {Math.Round(despesaDia03)}€.");
            Utility.WriteMessage($"\nNo 4º dia foi gasto {Math.Round(despesaDia04)}€.");
            Utility.WriteMessage($"\nEm média gastou {Math.Round(mediaDespesaTotal)}€.");


            Utility.TerminateConsole();

        }
    }
}
