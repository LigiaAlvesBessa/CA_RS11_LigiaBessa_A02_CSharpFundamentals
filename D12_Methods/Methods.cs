using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Methods
    {

        #region Métodos Void
        public void Procedure()
        {

            string message = "Procedimento: método void que não devolve valor.";
            Utility.WriteMessage(message, "", "\n\n");

        }

        public void WrongProcedure()
        {

            string message = "Procedimento: método não void - devolve valor";
            Utility.WriteMessage(message, "", "\n\n");

            int v1, v2, res;

            v1 = 10;
            v2 = 20;
            res = v1 + v2;

            Utility.WriteMessage(res.ToString());

        }

        #endregion

        #region Método Não Void
        public int Function()
        {
            string message = "Procedimento: método não void - devolve valor";
            Utility.WriteMessage(message, "", "\n\n");

            int v1, v2, res;

            v1 = 10;
            v2 = 20;
            res = v1 + v2;

            return res;
        }

        #endregion

        #region Método com parâmetros obrigatórios

        public void MethodRequiredParameters(string message01, string message02)
        {
            Utility.WriteMessage(message01, "", "\n");
            Utility.WriteMessage(message02, "", "\n\n");
        }


        #endregion

        #region Método com parâmetros opcionais

        public void MethodOptionalParameters(string message01, string message02 = "Opcionais")
        {
            Utility.WriteMessage(message01, "", "\n");
            Utility.WriteMessage(message02, "", "\n\n");
        }


        #endregion

        #region Métodos com parâmetros por valor

        /*public void PassingValues(int value);
        {
            value = 10;

            Utility.WriteMessage($"1. Valor ");
        }*/

        public void PassingValues(int value)
        {

        }

        #endregion

        #region Métodos com parâmetros por referência
        public void PassingReferences(ref int value)
        {

            value = 10; // mudar o valor implica mudar em todas as referências
            Utility.WriteMessage("dxf");
        }



        #endregion

        #region Método de instância




        #endregion

        #region Método estático

        public static void StaticMethod()
        {

            Utility.WriteMessage("Um método estático é chamado diretamente da classe", "", "\n\n\n");

        }


        #endregion

        #region Sobrecarga de métodos (overloading)





        #endregion
    }
}





