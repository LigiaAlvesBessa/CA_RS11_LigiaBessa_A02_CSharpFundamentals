
// Nome e Codigo do País (pt, br) 
// Verificar entre dois paises
// fazer 2 versões if e switch

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_AlgoritmoCodigoPais
{
    internal class Program
    {
        static void Main(string[] args)
        {

             // 1. Definir as variaveis

              string nome, codigoPais;

              // 2. Ler a variável nome

              Console.Write("Nome: ");
              nome = Console.ReadLine();

              // 3. Ler a Variável codigoPais

              Console.Write("Codigo do País: ");
              codigoPais = Console.ReadLine();

            /*  // 4. IF
         if (codigoPais == "br")
         {
             Console.WriteLine("Olá " + nome + " és do Brasil!");
         }
         else if (codigoPais == "pt")
         {
             Console.WriteLine("Olá " + nome + " és de Portugal!");
         }
         else if (codigoPais == "es")
         {
             Console.WriteLine("Olá " + nome + " és de Espanha!");
         }
         else if (codigoPais == "fr")
         {
             Console.WriteLine("Olá " + nome + " és de França!");
         }
         else if (codigoPais == "us")
         {
             Console.WriteLine("Olá " + nome + " és dos Estados Unidos da América!");
         }
         else
         {
             Console.WriteLine("Olá " + nome + " és de outro pais!");
         }*/

            // 4. Switch
            switch (codigoPais)
                {
                    case "br":
                        Console.WriteLine("Olá " + nome + " és do Brasil!");
                    break;
                    case "pt":
                        Console.WriteLine("Olá " + nome + " és de Portugal!");
                    break;
                    case "es":
                        Console.WriteLine("Olá " + nome + " és de Espanha!");
                    break;
                    case "fr":
                        Console.WriteLine("Olá " + nome + " és de França!");
                    break;
                    case "us":
                        Console.WriteLine("Olá " + nome + " és dos Estados Unidos da América!");
                    break;
                    default:
                        Console.WriteLine("Olá " + nome + " és de outro pais!");
                    break;
            }


            //5. Pausar a consola

            Console.ReadKey();

        }
    }
}
