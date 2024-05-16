
// Verificar se uma pessoa é maior de idade

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE01_VerificarSeUmaPessoaEMaiorDeIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Declarar as variáveis

            string nome;
            int idade;

            // 2. Ler a variável nome

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            // 3. Ler a variavel idade

            Console.Write("Idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            // 4. Verificar a idade

            if (idade > 18)
            {
                Console.WriteLine(nome + " tem " + idade + ", e é maior de idade.");
            }
            else
            {
                Console.WriteLine(nome + " tem " + idade + ", não é maior de idade.");
            }

            //Pausar a consola

            Console.ReadKey();

        }
    }
}
