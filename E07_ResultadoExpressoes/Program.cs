using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E07_ResultadoExpressoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.WriteTitle("Apresentação de Resultados");

            // 01. Atribuição de Variaveis

            double valor01, valor02, soma, divisao, restoDivisao;

            // 02. Atribuição de valores

            valor01 = 15;
            valor02 = 2;

            // 03. Calculos

            soma = valor01 + valor02;
            divisao = valor01 / valor02;
            restoDivisao = valor01 % valor02;

            // 04. Apresentação de Resultados

            Utility.WriteMessage($"\n{valor01}+{valor02}={soma}");
            Utility.WriteMessage($"\n{valor01}/{valor02}={divisao}");
            Utility.WriteMessage($"\nO resto da divisão de {valor01} por {valor02} é {restoDivisao}");

            Utility.TerminateConsole();

        }
    }
}
