



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Classes
{
    internal class Person
    {

        #region Fields

        public string address, city, country;

        #endregion

        #region Properties



        #region Auto-implemented properties (2.0)

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string NIF { get; set; }

        #endregion

        #region Classic properties (1.0)

        public string City
        {
            get { return city; }            // Ler o valor da Propriedade
            set { city = value; }           // Escrever o valor da Propriedade
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        #endregion

        #region Bodied-expression properties (3.0)

        public string Country
        {
            get => country;
            set => country = value;
        }


        #endregion

        #endregion

        #region Constructors

        // Substituto do default construtor
        public Person()
        {

            Id = 0;
            Name = "";
            NIF = string.Empty;
            Phone = "";
            Address = "";
            City = "";
            Country = "";

        }

        public Person(int id, string name)
        {

            Id = id;
            Name = name;

        }

        public Person(int id, string name, string nif, string phone, string address, string city, string country)
        {

            Id = id;
            Name = name;
            NIF = nif;
            Phone = phone;
            Address = address;
            City = city;
            Country = country;

        }


        #region Methods

        public void PersonReadData()
        {
            Utility.WriteTitle("Person - read");

            Utility.WriteMessage("Person id: ", "\n");
            Id = Convert.ToInt16(Console.ReadLine());         // debug, try... catch

            Utility.WriteMessage("Person name: ", "\n");
            Name = Console.ReadLine();

            Utility.WriteMessage("Person NIF: ", "\n");
            NIF = Console.ReadLine();

            Utility.WriteMessage("Person Phone: ", "\n");
            Phone = Console.ReadLine();

            Utility.WriteMessage("Person Address: ", "\n");
            Address = Console.ReadLine();

            Utility.WriteMessage("Person City: ", "\n");
            City = Console.ReadLine();

            Utility.WriteMessage("Person Country: ", "\n");
            Country = Console.ReadLine();


        }





        public void PersonWriteData()
        {

            Utility.WriteTitle("Person - List");

            Utility.WriteMessage($"Id: {Id}", "", "\n");
            Utility.WriteMessage($"Name: {Name}", "", "\n");
            Utility.WriteMessage($"NIF: {NIF}", "", "\n");
            Utility.WriteMessage($"Phone: {Phone}", "", "\n");
            Utility.WriteMessage($"Address: {Address}", "", "\n");
            Utility.WriteMessage($"City: {City}", "", "\n");
            Utility.WriteMessage($"Country: {Country}");

        }
        #endregion


        #endregion

        #region Methods



        #endregion

        #region Destructor



        #endregion

    }
}
