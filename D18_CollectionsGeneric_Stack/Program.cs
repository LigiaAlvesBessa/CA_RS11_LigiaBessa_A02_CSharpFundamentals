﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D18_CollectionsGeneric_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Stack<int> stackIntegers = new Stack<int>();
            stackIntegers.Push(0);
            stackIntegers.Push(1);

            for (int i = 2; i < 4; i++)
            {
                stackIntegers.Push(i);
            }

            Utility.WriteTitle("Push");

            foreach (int item in stackIntegers)
            {
                Utility.WriteMessage(item.ToString(), "\n", "");
            }

            Utility.WriteTitle("Pop");

            int countStack = stackIntegers.Count;

            for (int i = 0; i < countStack; i++)
            {
                Utility.WriteMessage($"{stackIntegers.Pop()}", "\n", "");
            }


            Utility.TerminateConsole();

        }
    }
}
