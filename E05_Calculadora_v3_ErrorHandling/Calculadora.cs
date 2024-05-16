using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_Calculadora_v3_ErrorHandling
{
    internal class Calculadora
    {

        #region Properties

        private double Valor01 { get; set; }
        private string Operacao { get; set; }
        private double Valor02 { get; set; }
        private double Resultado { get; set; }

        #endregion

        #region Constructors

        // Substituto do default construtor
        internal Calculadora()
        {
            Valor01 = 0;
            Operacao = string.Empty;
            Valor02 = 0;
            Resultado = 0;
        }

        internal Calculadora(double valor01, string operacao, double valor02, double resultado)
        {
            Valor01 = valor01;
            Operacao = operacao;
            Valor02 = valor02;
            Resultado = resultado;
        }

        #endregion

        #region Methods

        internal void CalculadoraMenu()
        {
            string[] formula = { "Soma: +\n", "Subtração: -\n", "Multiplicação: *\n", "Divisão: /\n" };

            Utility.WriteTitle("Calculadora");

            foreach (string i in formula)
            {
                Utility.WriteMessage(i);
            }

        }

        internal void CalculadoraLeDados()
        {
            Utility.WriteTitle("Pedido de Dados");

            Utility.WriteMessage("Valor 1: ", "\n");
            Valor01 = Convert.ToInt16(Console.ReadLine());         // debug, try... catch

            Utility.WriteMessage("Operação: ", "\n");
            Operacao = Console.ReadLine();

            Utility.WriteMessage("Valor 2: ", "\n");
            Valor02 = Convert.ToInt16(Console.ReadLine());

        }

        internal void Somar()
        {
            Resultado = Valor01 + Valor02;
        }

        internal void Subtrair()
        {
            Resultado = Valor01 - Valor02;
        }

        internal void Multiplicar()
        {
            Resultado = Valor01 * Valor02;
        }

        internal void Dividir()
        {
            Resultado = Valor01 / Valor02;
        }

        internal void CalculadoraOperacao()
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
                    if (Valor02 == 0)
                        throw new DivideByZeroException("Divisão por zero não é permitida.");
                    break;
                default:
                    Resultado = 0;
                    break;
            }
        }

        internal void CalculadoraEscreveDados()
        {

            Utility.WriteTitle("Leitura de Dados");

            Utility.WriteMessage($"{Valor01} {Operacao} {Valor02} = {Resultado}", "", "\n");

        }

        #endregion
    }














}
