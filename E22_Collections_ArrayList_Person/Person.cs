using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E22_Collections_ArrayList_Person
{
    internal class Person
    {

        internal int Id { get; set; }
        internal string Name { get; set; }

        // Construtores
        internal Person()
        {

            Id = 0;
            Name = string.Empty;

        }

        // Método
        internal Person(int id, string name)
        {

            Id = id;
            Name = name;

        }

        internal static void ListPerson(ArrayList list)
        {

            foreach (Person item in list)
            {
                Utility.WriteMessage($"{item.Id}, {item.Name}", "", "\n\n");

            }

        }
    }
}

