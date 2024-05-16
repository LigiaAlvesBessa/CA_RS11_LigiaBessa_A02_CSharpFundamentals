using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E09_ApresenteNumerosPercentagem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();



            // 01. Atribuição de Variáveis de valores

            double[] valores = { 8.456796, 9.8, 3.12345, 6 };
            double[] arredondamento3D = { Math.Round(8.456796, 3), Math.Round(9.8, 3), Math.Round(3.12345, 3), Math.Round(6.0, 3) };
            double[] arredondamento1D = { Math.Round(8.456796, 1), Math.Round(9.8, 1), Math.Round(3.12345, 1), Math.Round(6.0, 1) };
            double[] arredondamentoInt = { Math.Round(8.456796, 0), Math.Round(9.8, 0), Math.Round(3.12345, 0), Math.Round(6.0, 0) };

            // 02. Apresentar os valores

            Utility.WriteTitle("Valores sem arredondamento e sem Percentagem");
            foreach (double i in valores)
            {
                Utility.WriteMessage(Convert.ToString(i),"","\n");
            }


            // 03. Apresentar os valores com percentagem

            Utility.WriteTitle("Valores sem arredondamento e com Percentagem");
            foreach (double i in valores)
            {
                Utility.WriteMessage($"{Convert.ToString(i)}%", "", "\n");
            }


            // 04. Apresentar o arredondamento em 3 casas decimais e com Percentagem

            Utility.WriteTitle("Valores arredondados a 3 casa decimais e com Percentagem");
            foreach (double i in arredondamento3D)
            {
                Utility.WriteMessage($"{Convert.ToString(i)}%", "", "\n");
            }


            // 05. Apresentar o arredondamento em 1 casa decimal e com Percentagem

            Utility.WriteTitle("Valores arredondados a 1 casa decimal e com Percentagem");
            foreach (double i in arredondamento1D)
            {
                Utility.WriteMessage($"{Convert.ToString(i)}%", "", "\n");
            }


            // 06. Apresentar o arredondamento a número inteiro e com Percentagem

            Utility.WriteTitle("Valores arredondados a número inteiro e com Percentagem");
            foreach (double i in arredondamentoInt)
            {
                Utility.WriteMessage($"{Convert.ToString(i)}%", "", "\n");
            }


            Utility.TerminateConsole();
        }
    }
}
