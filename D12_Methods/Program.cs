using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Methods methods01 = new Methods();

            #region Método void

            Utility.WriteTitle("Procedure (método void)");
            methods01.Procedure();

            #endregion

            #region Método não void

            Utility.WriteTitle("Fuction (método não void)\n\n\n");

            // v1

            //Utility.WriteMessage(methods01.Function().ToString());

            //v2

            int res;
            res = methods01.Function();
            Utility.WriteMessage("\n",res.ToString(), "\n");

            #endregion

            #region Método com parâmetros obrigatórios

            Utility.WriteTitle("Método com parâmetros obrigatórios");
            methods01.MethodRequiredParameters("Passagem de parâmetros.","Obrigatórios.");

            #endregion

            #region Método com parâmetros opcionais

            Utility.WriteTitle("Método com parâmetros opcionais");
            methods01.MethodOptionalParameters("Passagem de parâmetros.");

            #endregion

            #region Métodos com parâmetros por valor

            Utility.WriteTitle("Métodos com parâmetros por valor");




            #endregion

            #region Métodos com parâmetros por referência

            Utility.WriteTitle("Métodos com parâmetros por referência");




            #endregion

            #region Método de instância

            Utility.WriteTitle("Método de instância");



            #endregion

            #region Método estático

            Utility.WriteTitle("Método estático");

            #endregion

            #region Sobrecarga de métodos (overloading)
            #endregion










            Utility.TerminateConsole();

        }
    }
}
