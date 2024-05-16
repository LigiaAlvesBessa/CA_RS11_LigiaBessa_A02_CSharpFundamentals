using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region 01. Listar as operações

            string[] menu =
            {
                "+ Soma",
                "- Subtração",
                "* Multiplicação",
                "/ Divisão"
            };

            #endregion

            #region 02. Pedir valores e operação

            string operacao, saida;
            double valor01, valor02, resultado;

            Utility.WriteMessage("Digite o valor 01: ");
            valor01 = Convert.ToInt64(Console.ReadLine());

            Utility.WriteMessage("Digite o operador: ");
            operacao = Console.ReadLine();

            Utility.WriteMessage("Digite o valor 02: ");
            valor02 = Convert.ToInt64(Console.ReadLine());

            #endregion

            #region 03. Realizar o cálculo

            switch (operacao)
            {
                case "+":
                    resultado = valor01 + valor02;
                    break;
                case "-":
                    resultado = valor01 - valor02;
                    break;
                case "*":
                    resultado = valor01 * valor02;
                    break;
                case "/":
                    resultado = valor01 / valor02;
                    break;
                default:
                    resultado = 0;
                    break;
            }

            #endregion

            #region 04. Mostrar o resultado

            saida = $"Resultado: {valor01} {operacao} {valor02} = {resultado}";
            Utility.WriteMessage(saida, "\n\n");

            #endregion

            Utility.TerminateConsole();

        }
    }
}
