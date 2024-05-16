using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E24_Collections_ListManipulation_Person
{
    internal class Menu
    {

        #region Propriedades
        internal int Id { get; set; }
        internal string Name { get; set; }

        #endregion

        #region Construtores
        internal Menu()
        {

            Id = 0;
            Name = string.Empty;

        }


        internal Menu(int id, string name)
        {

            Id = id;
            Name = name;

        }

        #endregion

        #region Método
        internal static void ListMenu(List<Menu> list)
        {

            foreach (Menu item in list)
            {
                Utility.WriteMessage($"{item.Id}. {item.Name}", "\n", "");


            }
            Utility.WriteMessage("> ", "\n\n", "");


        }

        internal static int ReadOption()
        {
            int optionMenu;
            while (!int.TryParse(Console.ReadLine(), out optionMenu))
            {
                Utility.WriteMessage("> ", "\n\n", "");
            }
            return optionMenu;
        }

        #endregion









    }
}
