using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region ArrayList: Multi tipos + inteiros

            // 01. Instanciar

            ArrayList listMulti = new ArrayList();
            ArrayList listIntegers = new ArrayList();

            // 02. Adicionar valores de tipos diferentes (um a um)

            listMulti.Add(10);
            listMulti.Add("a");
            listMulti.Add(false);
            listMulti.Add(DateTime.Today);

            // 03. Adicionar 5 valores do tipo inteiro automaticamente

            for (int i = 0; i < 5; i++)
            {
                listIntegers.Add(i);
            }

            // listIntegers.Add("Vou dar cabo desta lista");  // Mostrar a fraqueza do ArrayList

            listIntegers.Add(-30);
            listIntegers.Add(19);

            // 04. Quantos elementos na lista?

            Utility.WriteTitle("ArayList Contagem");
            Utility.WriteMessage($"Nª de elementos - listMulti: {listMulti.Count}", "", "\n\n");
            Utility.WriteMessage($"Nª de elementos - listIntegers: {listIntegers.Count}", "", "\n\n");

            // 05. Listar

            Utility.WriteTitle("ArrayList - listMulti");

            PersonUtility.ListData(listMulti);

            Utility.WriteTitle("ArrayList - listIntegers");

            PersonUtility.ListData(listIntegers);


            // 06. Listar, ordenando

            Utility.WriteTitle("ArrayList - listIntegers Ordenada");

            listIntegers.Sort();
            PersonUtility.ListData(listIntegers);

            #endregion

            #region Person

            // Criar 2 pessoas

            ArrayList listPerson = new ArrayList();

            Person person01 = new Person("Lígia Bessa", "Paços de Ferreira");
            Person person02 = new Person("Alexandra Mendes", "Porto");

            listPerson.Add(person01);
            listPerson.Add(person02);

            // Listar

            Utility.WriteTitle("ArrayList - listPerson");

            Person.ListPerson(listPerson);

            #endregion





            Utility.TerminateConsole();

        }
    }
}
