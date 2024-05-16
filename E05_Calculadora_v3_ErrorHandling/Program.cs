using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using System.Collections;

namespace E05_Calculadora_v3_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Calculadora calculo = new Calculadora();

            calculo.CalculadoraMenu();
            calculo.CalculadoraLeDados();
            calculo.CalculadoraOperacao();
            calculo.CalculadoraEscreveDados();

            #region Com Tratamento de Dados

            try
            {
                double valor01;

                Utility.WriteMessage("Introduz um número: ");

                valor01 = Convert.ToDouble(Console.ReadLine());

            }

            catch (Exception ex)
            {

                Utility.WriteMessage($"Erro: {ex.Message}", "\n\n");

            }

            try
            {
                double valor02;

                Utility.WriteMessage("Introduz um número: ");

                valor02 = Convert.ToDouble(Console.ReadLine());

            }

            catch (Exception ex)
            {

                Utility.WriteMessage($"Erro: {ex.Message}", "\n\n");

            }

            #endregion

            Utility.TerminateConsole();









        }
    }
}
