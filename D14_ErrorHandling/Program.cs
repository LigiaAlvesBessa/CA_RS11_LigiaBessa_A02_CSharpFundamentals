using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using D00_Utility;
=======
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e

namespace D14_ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

            Utility.SetUnicodeConsole();

            Utility.WriteTitle("Error handlinng");

            #region Sem Tratamento de Dados

            /*int number01;

            Utility.WriteMessage("Introduz um número: ");
            number01 = Convert.ToInt16(Console.ReadLine());*/




            #endregion

            #region Com Tratamento de Dados

            try
            {

                int number02;

                Utility.WriteMessage("Introduz um número: ");

                number02 = Convert.ToInt16(Console.ReadLine());

            }

            catch (FormatException ex)
            {

                Utility.WriteMessage("Escreve um número.", "", "\n\n");

            }

            catch (Exception ex)
            {

                // Versão de Desenvolvimento
                //throw;     //lançar o erro

                Utility.WriteMessage($"Erro: {ex.Message}", "\n\n");

                // Versão de Produção
                //Utility.WriteMessage("Aconteceu um erro.", "\n", "\n\n");

            }

            #endregion




            Utility.TerminateConsole();

=======
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
        }
    }
}
