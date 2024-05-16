using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D13_AcessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();


            User user01 = new User();

            user01.CreateUser();
<<<<<<< HEAD

            Utility.PauseConsole();

=======
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
            user01.ListUser();


            Utility.TerminateConsole();

        }
    }
}
