using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E19_IdadeDaquiA20Anos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            int idade, idadeFutura;
            Utility.WriteMessage("Indique a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            idadeFutura = idade + 20;

            Utility.WriteMessage($"Daqui a 20 anos terá {idadeFutura} anos.");


            Utility.TerminateConsole();

        }
    }
}
