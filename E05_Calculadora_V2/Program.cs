using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_Calculadora_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora calculo = new Calculadora();

            calculo.CalculadoraMenu();
            calculo.CalculadoraLeDados();
            calculo.CalculadoraOperacao();
            calculo.CalculadoraEscreveDados();

            Utility.TerminateConsole();
        }
    }
}
