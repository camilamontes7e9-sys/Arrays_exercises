using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Exercices.Helpers
{
    public class ErrorManager
    {
        //Error messages
        public const string IOErrorMsg = "\nError, Can not establish connection with the console";
        public const string UnknownError = "\nUnknown Error, please try again";
        public const string OverFlowErrorMsg = "\nError, input over  for an Integer32";
        public const string ArgumentNullErrorMsg = "\nError, can not accept a null argument";
        public const string FormatExceptionErrorMsg = "\nError, the input must be a valid number, enter an integer number";
        public const string IndexOutOfRangeMsg = "\nInvalid index, out of range of the array";

        //Exercise 2
        public const string InvalidMsg = "\nInvalid option";

        //Exercise 12
        public const string PassWordOutOfRange = "\nError, the pasword must contain ";


        //Method to print the specific errors
        public static void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
    }
}
