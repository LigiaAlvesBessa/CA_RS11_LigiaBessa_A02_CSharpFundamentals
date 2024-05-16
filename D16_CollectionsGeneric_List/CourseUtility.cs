using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D16_CollectionsGeneric_List
{
    internal class CourseUtility
    {

        internal static void ListData(List<int> list)
        {

            foreach (int item in list)
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }

        }

        internal static void ListData(List<string> list)
        {

            foreach (string item in list)
            {
                Utility.WriteMessage($"{item}", "", "\n");
            }

        }

    }
}
