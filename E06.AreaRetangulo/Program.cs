using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06.AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.WriteTitle("Calculo da Área do Retangulo");

            //01. Identificação de Variaveis

            double area, altura, largura;

            //02. Pedir os valores

            Utility.WriteMessage("Indique a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Utility.WriteMessage("Indique a largura: ");
            largura = Convert.ToDouble(Console.ReadLine());

            //03. Calculo da Área
            area = altura * largura;

            //04. Apresentação de resultados
            Utility.WriteMessage($"A área é igual a {area}");




            Utility.TerminateConsole();

        }
    }
}
