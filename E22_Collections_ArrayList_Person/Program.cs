using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E22_Collections_ArrayList_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            ArrayList listPerson = new ArrayList();
            int id = 1;

            Utility.WriteTitle("Person - Insert");

            do
            {
                Utility.WriteMessage("Name: ", "\n", "");
                string name = Console.ReadLine();

                listPerson.Add(new Person(id++, name));

                Utility.WriteMessage("Continue (y/n)? ", "\n", "");

            } while (Console.ReadLine().ToLower() == "y");

            // Listar

            Utility.WriteTitle("Person - List");
            Person.ListPerson(listPerson);



            Utility.TerminateConsole();

        }
    }
}
