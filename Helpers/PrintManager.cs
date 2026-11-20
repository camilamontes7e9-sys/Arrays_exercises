using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Exercices.Helpers
{
    public class PrintManager
    {
        public const string Space = "----------------------------";
        public const string Menu = "\n------------MENU------------";
        public static void PrintMenu()
        {
            
            const string InitialMsg = "To access an activity enter wich one you want to access: ";
            const string MenuMsg = "Exercise {0} (Arrays): ";
            const string MenuMsgTwo = "Exercise {0} (Matrix): ";
            const string ExitMsg = "Enter 0 to exit: ";
            const int AuxNum = 7, AuxNumTwo = 14;

            int InputNumber = 0;

            Console.WriteLine($"\n{Menu} \n{InitialMsg} \n{Space}");

            for (int i = 1; i < AuxNum; i++)
            {
                Console.Write($"{InputNumber +i}. ");
                Console.WriteLine(MenuMsg, i);
            }

            Console.WriteLine(Space);

            for (int i = 1; i < AuxNumTwo; i++)
            {
                InputNumber = 6;
                Console.Write($"{InputNumber + i}. ");
                Console.WriteLine(MenuMsgTwo, i);
            }
            Console.WriteLine($"\n{ExitMsg}");
        }

        public static void PrinteMenuExSeven()
        {
            const string OptionOneMsg = "1 - I want to dig!";
            const string OptionTwoMsg = "2 - Display the map on the screen";
            const string ExitMsg = "3 - Sortir";

            Console.WriteLine(OptionOneMsg);
            Console.WriteLine(OptionTwoMsg);
            Console.WriteLine(ExitMsg);
        }
    }
}
