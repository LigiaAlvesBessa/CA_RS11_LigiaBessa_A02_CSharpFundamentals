using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E12_PeçaNomeEApelidoMensagemParabens
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            string nome, apelido;
            Utility.WriteMessage("Indique o seu nome: ");
            nome = Console.ReadLine();

            Utility.WriteMessage("Indique o seu apelido: ");
            apelido = Console.ReadLine();

            Utility.WriteMessage($"{nome} {apelido}, acabou de ganhar o 1º prémio. Parabéns!", "\n", "");


            Utility.TerminateConsole();

        }
    }
}
