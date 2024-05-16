using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace D13_AcessModifiers
{
    internal class User
    {

        #region Properties

        // Auto Implemented 

<<<<<<< HEAD
        internal int Id { get; }
        internal string Name { get; set; }
        internal string Department { get; set; }
        internal string UserName { get; set; }
        internal string PassWord { get; set; }
=======
        public int Id { get; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e


        // Classic Mode

<<<<<<< HEAD
        private DateTime registrationDate;
        internal DateTime RegistrationDate
=======
        public DateTime registrationDate;
        public DateTime RegistrationDate
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
        {
            get { return registrationDate; }
            set { registrationDate = value; }

        }
        #endregion

        #region Constructors

<<<<<<< HEAD
        internal User()
=======
        public User()
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
        {
            Id = 01;
            Name = string.Empty;
            Department = string.Empty;
            RegistrationDate = DateTime.Today;
            UserName = string.Empty;
            PassWord = string.Empty;
        }


<<<<<<< HEAD
        internal User(int id, string name, string department, string userName, string passWord, DateTime registrationDate)
=======
        public User(int id, string name, string department, string userName, string passWord, DateTime registrationDate)
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
        {
            Id = 1;
            Name = name;
            Department = department;
            UserName = userName;
            PassWord = passWord;
            RegistrationDate = registrationDate;
        }

        #endregion

        #region Methods

<<<<<<< HEAD
        internal void CreateUser()
=======
        public void CreateUser(DateTime v)
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
        {
            Utility.WriteTitle("Create User");

            Utility.WriteMessage("Name: ");
            Name = Console.ReadLine();

            Utility.WriteMessage("Department: ");
            Department = Console.ReadLine();

<<<<<<< HEAD
            Utility.WriteMessage("Registration Date: ");
            while (DateTime.TryParse(Console.ReadLine(), out registrationDate))
            {
                Utility.WriteMessage("Inserir uma data válida (ex. 30/04/2024): ");
            }

=======
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
            Utility.WriteMessage("UserName: ");
            UserName = Console.ReadLine();

            Utility.WriteMessage("PassWord: ");
            PassWord = Console.ReadLine();

<<<<<<< HEAD
        }


        internal void ListUser()
=======
            Utility.WriteMessage("Registration Date: ");
            RegistrationDate = Convert.ToDateTime(Console.ReadLine());

            Utility.PauseConsole();

        }


        public void ListUser()
>>>>>>> 57a7bb41433b93cc82055e315dee8e65b9dab18e
        {
            Utility.WriteTitle("List User");

            Utility.WriteMessage($"Id: {Id}", "", "\n");
            Utility.WriteMessage($"Name: {Name}", "", "\n");
            Utility.WriteMessage($"Department: {Department}", "", "\n");
            Utility.WriteMessage($"UserName: {UserName}", "", "\n");
            Utility.WriteMessage($"PassWord: {PassWord}", "", "\n");
            Utility.WriteMessage($"Registration Date: {RegistrationDate}", "", "\n");

        }



        #endregion




    }
}
