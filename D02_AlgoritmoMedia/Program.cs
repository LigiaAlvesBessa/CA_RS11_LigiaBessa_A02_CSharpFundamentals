using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_AlgoritmoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Declarar as variáveis

            string valor01;
            int valor02;
            double resultado;

            // 2. Pedir o 1º valor

            Console.Write("Número 1: ");
            valor01 = Console.ReadLine(); // Quando for fazer o cálculo, vou ter de converter

            // 3. Pedir p 2º valor

            Console.Write("Número 2: ");
            valor02 = Convert.ToInt16(Console.ReadLine()); // vou ter de converter ao ler o valor

            // 4. Calcular a média

            resultado = (Convert.ToDouble(valor01) + Convert.ToDouble(valor02)) / 2; // Converti o valor2 para não fazer autoconvert

            // 5. Mostrar o resultado

            Console.WriteLine("Média: " + resultado.ToString()); // melhorar a concatenação

            // 6. Pausar a consola

            Console.ReadKey();


        }
    }
}
