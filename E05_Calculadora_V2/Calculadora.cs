using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E05_Calculadora_V2
{
    internal class Calculadora
    {

        #region Properties

        public double Valor01 { get; set; }
        public string Operacao { get; set; }
        public double Valor02 { get; set; }
        public double Resultado { get; set; }

        #endregion

        #region Constructors

        // Substituto do default construtor
        public Calculadora()
        {
            Valor01 = 0;
            Operacao = string.Empty;
            Valor02 = 0;
            Resultado = 0;
        }

        public Calculadora(double valor01, string operacao, double valor02, double resultado)
        {
            Valor01 = valor01;
            Operacao = operacao;
            Valor02 = valor02;
            Resultado = resultado;
        }

        #endregion

        #region Methods

        public void CalculadoraMenu()
        {
            string[] formula = { "Soma: +\n", "Subtração: -\n", "Multiplicação: *\n", "Divisão: /\n" };

            Utility.WriteTitle("Calculadora");
            
            foreach (string i in formula)
            {
                Utility.WriteMessage(i);
            }

        }

        public void CalculadoraLeDados()
        {
            Utility.WriteTitle("Pedido de Dados");

            Utility.WriteMessage("Valor 1: ", "\n");
            Valor01 = Convert.ToInt16(Console.ReadLine());         // debug, try... catch

            Utility.WriteMessage("Operação: ", "\n");
            Operacao = Console.ReadLine();

            Utility.WriteMessage("Valor 2: ", "\n");
            Valor02 = Convert.ToInt16(Console.ReadLine());

        }

        public void Somar()
        {
            Resultado = Valor01 + Valor02;
        }

        public void Subtrair()
        {
            Resultado = Valor01 - Valor02;
        }

        public void Multiplicar()
        {
            Resultado = Valor01 * Valor02;
        }

        public void Dividir()
        {
            Resultado = Valor01 / Valor02;
        }

        public void CalculadoraOperacao()
        {
            switch (Operacao)
            {
                case "+":
                    Somar();
                    break;
                case "-":
                    Subtrair();
                    break;
                case "*":
                    Multiplicar();
                    break;
                case "/":
                    Dividir();
                    break;
                default:
                    Resultado = 0;
                    break;
            }
        }

        public void CalculadoraEscreveDados()
        {

            Utility.WriteTitle("Leitura de Dados");

            Utility.WriteMessage($"{Valor01} {Operacao} {Valor02} = {Resultado}", "", "\n");

        }

        #endregion
    }
}
