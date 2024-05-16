using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E08_ApresenteNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 01. Atribuição de Variáveis

            double valor01, valor02, valor03, valor04, arredondamento3d01, arredondamento3d02, arredondamento3d03, arredondamento3d04,arredondamento1d01, arredondamento1d02, arredondamento1d03, arredondamento1d04, arredondamentoInt01, arredondamentoInt02, arredondamentoInt03, arredondamentoInt04;

            // 02. Atribuição de valores ás variáveis

            valor01 = 8.456796;
            valor02 = 9.8;
            valor03 = 3.12345;
            valor04 = 6;

            // 03. Apresentar os valores

            Utility.WriteTitle("Valores sem arredondamento");
            Utility.WriteMessage($"{valor01}");
            Utility.WriteMessage($"\n{valor02}");
            Utility.WriteMessage($"\n{valor03}");
            Utility.WriteMessage($"\n{valor04}\n\n");

            // 04. Arredondar em 3 casas decimais

            arredondamento3d01 = Math.Round(valor01, 3);
            arredondamento3d02 = Math.Round(valor02, 3);
            arredondamento3d03 = Math.Round(valor03, 3);
            arredondamento3d04 = Math.Round(valor04, 3);

            // 05. Apresentar os arredondamentos

            Utility.WriteTitle("Arredondamento em 3 casas decimais");
            Utility.WriteMessage($"{arredondamento3d01}");
            Utility.WriteMessage($"\n{arredondamento3d02}");
            Utility.WriteMessage($"\n{arredondamento3d03}");
            Utility.WriteMessage($"\n{arredondamento3d04}\n\n");

            // 06. Arredondar em 1 casa decimal

            arredondamento1d01 = Math.Round(valor01, 1);
            arredondamento1d02 = Math.Round(valor02, 1);
            arredondamento1d03 = Math.Round(valor03, 1);
            arredondamento1d04 = Math.Round(valor04, 1);

            // 07. Apresentar os arredondamentos

            Utility.WriteTitle("Arredondamento em 1 casa decimal");
            Utility.WriteMessage($"{arredondamento1d01}");
            Utility.WriteMessage($"\n{arredondamento1d02}");
            Utility.WriteMessage($"\n{arredondamento1d03}");
            Utility.WriteMessage($"\n{arredondamento1d04}\n\n");

            // 09. Arredondar em número inteiro

            arredondamentoInt01 = Math.Round(valor01, 0);
            arredondamentoInt02 = Math.Round(valor02, 0);
            arredondamentoInt03 = Math.Round(valor03, 0);
            arredondamentoInt04 = Math.Round(valor04, 0);

            // 10. Apresentar os arredondamentos

            Utility.WriteTitle("Arredondamento em número inteiro");
            Utility.WriteMessage($"{arredondamentoInt01}");
            Utility.WriteMessage($"\n{arredondamentoInt02}");
            Utility.WriteMessage($"\n{arredondamentoInt03}");
            Utility.WriteMessage($"\n{arredondamentoInt04}");



            Utility.TerminateConsole();
        }
    }
}
