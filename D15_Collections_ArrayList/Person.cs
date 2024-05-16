using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Person
    {

        // Propriedades
        internal string Name { get; set; }
        internal string City { get; set; }

        // Construtores
        internal Person()
        {

            Name = string.Empty;
            City = string.Empty;

        }

        // Método
        internal Person(string name, string city)
        {

            Name = name;
            City = city;

        }

        internal static void ListPerson(ArrayList list)
        {

            foreach (Person item in list)
            {
                Utility.WriteMessage($"{item.Name}, {item.City}", "", "\n\n");


            }

        }

    }
}
