using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_DataTipes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Declarar variáveis e criar objetos

            byte idade; // 0 - 255
            float altura;
            double peso;
            bool inscrito; // True (1) False (0)
            DateTime data;
            DateTime hora;
            DateTime agora;
            DateTime dataAtual;
            DateTime dataVazia;

            string nomeCompleto; // objeto!!!

            #endregion

            #region 2. Atribuir valores
            
            // Números
            idade = 10;
            altura = 20.5F;
            peso = 10.5;

            // Booleano
            inscrito = true;

            // Datas
            data = new DateTime(2024, 4, 1);
            hora = new DateTime(2024, 4, 1, 19, 5, 0);
            agora = DateTime.Now;              // Timestamp: data + hora
            dataAtual = DateTime.Today;        // Data
            dataVazia = DateTime.MinValue;     // 1/1/0001 12:00:00 AM

            // String

            nomeCompleto = "Lígia Bessa";

            #endregion

            #region 3. Declarar e atribuir

            string horario = "19:00 - 22:00";

            #endregion

            #region 4. Vetores


            #endregion

            #region 5. Matrizes (array)



            #endregion

            #region 6. Trabalhar na consola

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Variáveis Numéricas");
            Console.WriteLine("--------------------------------");

            // As string são imutáveis (é um endereço de memória na heap)

            Console.WriteLine("\nBite - idade: " + idade); // Não concatenar com o +

            // String interpolation: safe concatenation

            Console.WriteLine($"Float - altura: {altura}");
            Console.WriteLine($"Double - altura: {peso}\n\n\n");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Variável Boleana");
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"\nBoolean - inscrito: {inscrito.ToString()}\n\n\n");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Variável String");
            Console.WriteLine("--------------------------------");

            // Deve-se concatenar strings com av classe StringBuilder e o método Add

            Console.WriteLine($"\nString - nome completo: {nomeCompleto}");
            Console.WriteLine($"String - horário: {horario}\n\n\n");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Variável String");
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"\nDate - data: {data}");

            Console.WriteLine($"Long Date - data: {data.ToLongDateString()}");
            Console.WriteLine($"Short Date - data: {data.ToShortDateString()}");

            Console.WriteLine($"Date - hora: {hora}");

            Console.WriteLine($"Long Time - data: {data.ToLongTimeString()}");
            Console.WriteLine($"Short Time - data: {data.ToShortTimeString()}");

            Console.WriteLine($"Date - agora: {agora}");
            Console.WriteLine($"Date - data atual: {dataAtual}");
            Console.WriteLine($"Date - data vazia: {dataVazia}");

            /*
            Console.WriteLine($"");
            Console.WriteLine($"");
            */

            

            #endregion

            // Pausa a consola

            Console.ReadKey();

        }
    }
}
