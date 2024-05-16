using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E18_ConverterSegundosEmHorasMinutosSegundos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            int ss, s, m, h;
            Utility.WriteMessage("Intruduza o número em segundos: ");
            ss = Convert.ToInt32(Console.ReadLine());

            // Todas as divisões efetuadas neste exercicio são divisões inteiras

            s = ss % 60;        // segundos - %: resto da divisão inteira
            m = (ss / 60) % 60; // minutos
            h = (ss / 60) / 60; // horas

            Console.WriteLine("\n{0:D2}:{1:D2}:{2:D2}", h, m, s);


            Utility.TerminateConsole();

        }
    }
}
