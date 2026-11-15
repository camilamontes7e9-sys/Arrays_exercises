using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Exercices.Helpers
{
    public class ErrorManager
    {
        //Error messages
        public const string IOErrorMsg = "Error, Can not establish connection with the console";
        public const string UnknownError = "Unknown Error, please try again";
        public const string OverFlowErrorMsg = "Error, input over  for an Integer32";
        public const string ArgumentNullErrorMsg = "Error, can not accept a null argument";
        public const string FormatExceptionErrorMsg = "Error, the input must be a valid number, enter an integer number";

        //Exercise 12
        public const string PassWordOutOfRange = "Error, the pasword must contain ";


        //Method to print the specific errors
        public static void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
    }
}
