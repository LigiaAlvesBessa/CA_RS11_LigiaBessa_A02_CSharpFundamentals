
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E24_Collections_ListManipulation_Person
{
    internal class Person
    {

        // Todo MRS: para simplificar, tiha sugerido somente id e nome.
        #region Propriedades
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Phone { get; set; }
        internal string NIF { get; set; }
        internal string City { get; set; }

        #endregion

        #region Construtores
        internal Person()
        {

            Id = 0;
            Name = string.Empty;
            Phone = string.Empty;
            NIF = string.Empty;
            City = string.Empty;

        }

        // Todo MRS: implementar o id automático e sequencial pelo construtor.
        internal Person(int id, string name, string phone, string nif, string city)
        {

            Id = id;
            Name = name;
            Phone = phone;
            NIF = nif;
            City = city;

        }

        #endregion

        #region Método
        internal static void ListPerson(List<Person> list)
        {

            foreach (Person item in list)
            {
                Utility.WriteMessage($"Id: {item.Id}, Name: {item.Name}, Phone: {item.Phone}, NIF: {item.NIF}, City: {item.City}", "\n", "");


            }

        }

        internal static void AddPerson(List<Person> list)
        {
            int newId;
            string name, phone, nif, city;

            Utility.WriteMessage("Name: ", "\n", "");
            name = Console.ReadLine();

            Utility.WriteMessage("Phone: ", "\n", "");
            phone = Console.ReadLine();

            Utility.WriteMessage("NIF: ", "\n", "");
            nif = Console.ReadLine();

            Utility.WriteMessage("City: ", "\n", "");
            city = Console.ReadLine();

            // Todo MRS: implementar o id automático e sequencial pelo construtor.
            newId = list.Count + 1;

            Person person01 = new Person(newId, name, phone, nif, city);

            list.Add(person01);
            Utility.WriteMessage("Person add sucessfull!", "\n\n", "");
            
                
        }

        internal static void InsertPerson(List<Person> list)
        {

            int position;
            string name, phone, nif, city;

            Utility.WriteMessage("Name: ", "\n", "");
            name = Console.ReadLine();

            Utility.WriteMessage("Phone: ", "\n", "");
            phone = Console.ReadLine();

            Utility.WriteMessage("NIF: ", "\n", "");
            nif = Console.ReadLine();

            Utility.WriteMessage("City: ", "\n", "");
            city = Console.ReadLine();

            // Todo MRS: podias ter criado um método para o try.parse.
            Utility.WriteMessage("Position: ", "\n", "");
            position = Convert.ToInt32(Console.ReadLine());

            Person person01 = new Person(0, name, phone, nif, city);

            list.Insert(position, person01);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Id = i + 1;
            }

            Utility.WriteMessage("Person insert sucessfull!", "\n\n", "");
        }

        internal static void FindPersonId(List<Person> list)
        {

            Utility.WriteMessage("Search for Id: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Person person = list.Find(p => p.Id == id);
                if (person != null)
                {
                    Console.WriteLine($"Person found: {person.Id}, {person.Name}, {person.Phone}, {person.NIF}, {person.City}");
                }
                else
                {
                    Utility.WriteMessage("Person not found.");
                }
            }
            else
            {
                Utility.WriteMessage("Invalid ID. Please enter a number.");
            }

        }

        internal static void RemovePersonId(List<Person> list)
        {
            
            Utility.WriteMessage("Search for Id: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Person personToRemove = list.Find(p => p.Id == id);
                if (personToRemove != null )
                {
                    Console.WriteLine($"Person found: {personToRemove.Id}, {personToRemove.Name}, {personToRemove.Phone}, {personToRemove.NIF}, {personToRemove.City}");
                    list.Remove(personToRemove);
                    Utility.WriteMessage("Person removed sucessfull", "\n\n", "");
                }

                else
                {
                    Utility.WriteMessage("Person not found.");
                }
            }
            else
            {
                Utility.WriteMessage("Invalid ID. Please enter a number.");
            }



        }

        internal static void SortListPersonId(List<Person> list)
        {

            Utility.WriteMessage("Sort by Id: ");
            if (int.TryParse(Console.ReadLine(),out int id))
            {
                Person personPosition = list.Find(p =>p.Id == id);
                if (personPosition != null )
                {
                    list.Sort((p1, p2) => p1.Id.CompareTo(p2.Id));
                    Utility.WriteMessage("List sorted by id.", "", "\n");
                    Person.ListPerson(list);
                }
                else
                {
                    Utility.WriteMessage("Person not found.");
                }
            }
            else
            {
                Utility.WriteMessage("Invalid ID. Please enter a number.");
            }

        }

        internal static void SortListPersonName(List<Person> list)
        {

            Utility.WriteMessage("Sort by Name: ");
            string namePosition;
            namePosition = Console.ReadLine();

            if (namePosition != null)
            {
                list.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
                Utility.WriteMessage("List sorted by Name.", "", "\n");
                Person.ListPerson(list);
            }
            else
            {
                Utility.WriteMessage("Person not found.");
            }

        }

    }



        #endregion


    
}
