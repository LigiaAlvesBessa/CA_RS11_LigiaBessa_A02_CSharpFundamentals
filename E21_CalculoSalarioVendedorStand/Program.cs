using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E21_CalculoSalarioVendedorStand
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            float x, y, p, v, q;
            Utility.WriteMessage("Qual o Salário Base: ");
            x = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Qual é a comissão por automóvel: ");
            y = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Quantos automóveis vendeu: ");
            q = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Qual é a percentagem sobre o valor das vendas: ");
            p = Convert.ToSingle(Console.ReadLine());

            Utility.WriteMessage("Qual é o valor das vendas: ");
            v = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Salário Mensal: {0:F2}€.", x + q * y + p * v);



            Utility.TerminateConsole();

        }
    }
}
