using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();


            // 01.1. Instanciar a classe Person

            Person person01 = new Person();      // Método Construtor

            // 01.2. Atribuir valores às propriedades

            person01.Id = 1;
            person01.Name = "Pessoa 01";
            person01.NIF = "123456789";
            person01.Phone = "123456789";
            person01.Address = "Rua aqui, 10";
            person01.City = "Cidade";
            person01.Country = "Portugal";


            //02. Instanciar a classe Person e imediatamente passo os valores

            Person person02 = new Person(2, "Pessoa 2", "123123123", "321321321", "Rua de Lá, 20","Cidade", "Portugal");
            Person person03 = new Person(3, "Pessoa 3");


            // 03. Usar os métodos

            Person person4 = new Person();

            person4.PersonReadData();

            person01.PersonWriteData();



            Utility.TerminateConsole();

        }
    }
}
