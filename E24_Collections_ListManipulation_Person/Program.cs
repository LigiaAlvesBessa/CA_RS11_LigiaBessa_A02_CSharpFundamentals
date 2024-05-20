using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E24_Collections_ListManipulation_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.SetUnicodeConsole();


            List<Menu> listMenu = new List<Menu>();
            List<Person> personList = new List<Person>();
            //List<Person> personToRemove = new List<Person>();

            Menu menu01 = new Menu(1, "Add person");
            Menu menu02 = new Menu(2, "Insert person in position");
            Menu menu03 = new Menu(3, "Find person by id");
            Menu menu04 = new Menu(4, "Remove person by id");
            Menu menu05 = new Menu(5, "Sort list by id");
            Menu menu06 = new Menu(6, "Sort list by name");
            Menu menu07 = new Menu(7, "List person");
            Menu menu08 = new Menu(8, "Exit");

            listMenu.Add(menu01);
            listMenu.Add(menu02);
            listMenu.Add(menu03);
            listMenu.Add(menu04);
            listMenu.Add(menu05);
            listMenu.Add(menu06);
            listMenu.Add(menu07);
            listMenu.Add(menu08);

            Person person01 = new Person(1, "Lígia", "939446411", "239906250", "Paços de Ferreira");
            personList.Add(person01);
            Person person02 = new Person(2, "Beatriz", "912345678", "231234567", "Porto");
            personList.Add(person02);
            Person person03 = new Person(3, "Margarida", "932547980", "142525353", "Lisboa");
            personList.Add(person03);
            Person person04 = new Person(4, "Miguel", "912325357", "243627281", "Paredes");
            personList.Add(person04);

            Utility.WriteTitle("Menu");

            bool next = true;

            while (next)
            {
                Menu.ListMenu(listMenu);
                int optionMenu = Menu.ReadOption();

                switch (optionMenu)
                {
                    case 1:

                        Console.Clear();
                        Utility.WriteTitle("Add Person");

                        Person.AddPerson(personList);

                        Utility.PauseConsole();

                        break;
                    case 2:

                        Console.Clear();
                        Utility.WriteTitle("Insert person in position");

                        Person.InsertPerson(personList);

                        Utility.PauseConsole();

                        break;
                    case 3:

                        Console.Clear();
                        Utility.WriteTitle("Find person by id");

                        Person.FindPersonId(personList);

                        Utility.PauseConsole();

                        break;
                    case 4:

                        Console.Clear();
                        Utility.WriteTitle("Remove person by id");

                        Person.RemovePersonId(personList);


                        Utility.PauseConsole();

                        break;
                    case 5:

                        Console.Clear();
                        Utility.WriteTitle("Sort list by id");


                        Person.SortListPersonId(personList);

                        Utility.PauseConsole();

                        break;
                    case 6:

                        Console.Clear();
                        Utility.WriteTitle("Sort list by name");

                        Person.SortListPersonName(personList);

                        Utility.PauseConsole();

                        break;
                    case 7:

                        Console.Clear();
                        Utility.WriteTitle("List person");

                        Person.ListPerson(personList);

                        Utility.PauseConsole();

                        break;
                    case 8:

                        Utility.TerminateConsole();

                        break;
                }
            }

        }
    }
}
