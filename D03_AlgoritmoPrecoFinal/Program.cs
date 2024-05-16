// Calcular o preço final dum produto, mediante o preço inicial e a taxa de desconto

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace D03_AlgoritmoPrecoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Definir variaveis
            string nomeProduto;
            double precoProduto, taxaDesconto, precoProdutoFinal;

            // 2. Pedir o nome do produto

            Console.Write("Nome do Produto: ");
            nomeProduto = Console.ReadLine();

            // 3. Pedir o preço do produto

            Console.Write("Preço do Produto: ");
            precoProduto = Convert.ToDouble(Console.ReadLine());

            // 4. Pedir taxa de desconto

            Console.Write("Taxa de desconto: ");
            taxaDesconto = Convert.ToDouble(Console.ReadLine());

            // 5. Calcular o preço final
            
            precoProdutoFinal = precoProduto - (precoProduto*taxaDesconto/100);

            // 6. Mostrar o preço final

            //Console.WriteLine("Preço Final com desconto: " + precoProdutoFinal);
            Console.Write("O produto " + nomeProduto + " custa " + precoProdutoFinal.ToString());

            // 7. Pausar a consola

            Console.ReadKey();


        }
    }
}
