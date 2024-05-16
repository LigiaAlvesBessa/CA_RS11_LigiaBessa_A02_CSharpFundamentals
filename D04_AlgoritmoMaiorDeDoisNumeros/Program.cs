
// Decidir qual de dois números é o maior, ou se são iguais


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_AlgoritmoMaiorDeDoisNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Definir as variáveis

            int numero1, numero2;

            // 2. Ler o valor 1

            Console.Write("Número 1: ");
            numero1 = Convert.ToInt16(Console.ReadLine());

            // 3. Ler o valor 2

            Console.Write("Número 2: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            // 4. Comparação de números

            if (numero1 > numero2)
                {
                    Console.WriteLine("O número " + numero1 + " é maior do que o número " + numero2);
                }
            else if (numero1 < numero2)
                {
                    Console.WriteLine("O número " + numero1 + " é menor do que o número " + numero2);
                }
            else
            {
                Console.WriteLine("O número " + numero1 + " é igual ao número " + numero2);
            }

            //Pausar a consola

            Console.ReadKey();

        }
    }
}
