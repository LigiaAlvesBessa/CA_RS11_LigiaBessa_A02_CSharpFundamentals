
// Verificar se uma pessoa pode votar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace EE02_VerificarSeUmaPessoaPodeVotar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Declarar as variáveis

            string nome, nacionalidade;
            int idade;

            // 2. Ler a variável nome

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            // 3. Ler a variavel idade

            Console.Write("Idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            // 4. Ler a variável nacionalidade

            Console.Write("Nacionalidade: ");
            nacionalidade = Console.ReadLine();

            // 5. Verificar se pode votar

            if (idade >= 18 && nacionalidade == "Portuguesa")
            {
                Console.WriteLine($ nome ," tem ", idade, " e é de ", nacionalidade, ", por isso pode votar.");
            }
            else if (idade < 18 && nacionalidade == "Portuguesa")
            {
                Console.WriteLine(nome + " tem " + idade + ", por isso não pode votar.");
            }

            //Pausar a consola

            Console.ReadKey();



        }
    }
}
