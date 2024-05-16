using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E10_Pedir3NumerosAoUtilizador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            float a, b, c;

            Utility.WriteMessage("Introduza um número: ");
            a = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Introduza um número: ");
            b = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Introduza um número: ");
            c = Convert.ToSingle(Console.ReadLine());

            // São reservados 20 caracteres para escrever cada número.
            // O alinhamento é à esquerda faz-se com o sinal - (menos).
            Console.WriteLine("{0, -20:F2}{1,-20:F2}{2, -20:F2}", a, b, c);

            // O alinhamento é à direita faz-se por omissão.
            Console.WriteLine("{0, 20:F1}{1,20:F1}{2, 20:F1}", a, b, c);

            Utility.TerminateConsole();

        }
    }
}
