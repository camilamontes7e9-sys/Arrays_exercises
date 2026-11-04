using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Exercises
{
    public class ErrorManager
    {
        //Error messages
        public const string IOErrorMsg = "Error, Can not establish connection with the console";
        public const string UnknownError = "Unknown Error, enter a valid input";
        public const string OutOfRangeErrorMsg = "Error, argument out of range";
        public const string OutOfMemoryErrorMsg = "Error, the input is out of range";
        public const string ArgumentNullErrorMsg = "Error, the input must not be null, enter a valid input ";

        //Method to print the specific errors
        public void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
    }
}
