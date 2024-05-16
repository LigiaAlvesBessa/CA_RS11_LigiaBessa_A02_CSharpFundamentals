using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using D00_Utility;

namespace D16_CollectionsGeneric_List
{
    internal class Course
    {

        // Propriedades
        internal string Code { get; set; }
        internal string Area { get; set; }
        internal string Title { get; set; }

        // Construtores
        internal Course()
        {

            Code = string.Empty;
            Area = string.Empty;
            Title = string.Empty;

        }

        internal Course(string code, string area, string title)
        {

            Code = code;
            Area = area;
            Title = title;

        }

        // Método
        internal static void ListCourse(List<Course> list)
        {
            foreach (Course item in list)
            {
                Utility.WriteMessage($"Course {item.Code}: {item.Area} - {item.Title}", "", "\n");
            }
        }
    }
}
