using Array_Exercices.Helpers;
using Array_Exercises.Exercices;
using System;
using System.Text;

namespace Activities_
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; 

            string input = "";
            int convertedInput;
            bool exit = false;

            while (!exit)
            {
                try
                {
                    PrintManager.PrintMenu();

                    input = Console.ReadLine();
                    convertedInput = int.Parse(input);
                    Console.WriteLine("");

                    switch (convertedInput)
                    {
                        case 0: exit = true;break;
                        case 1: Warming.ExerciseOne(); break;
                        case 2: Warming.ExerciseTwo(); break;
                        case 3: Warming.ExerciseThree(); break;
                        case 4: Warming.ExerciseFour(); break;
                        case 5: Warming.ExerciseFive(); break;
                        case 6: Warming.ExerciseSix(); break;
                        case 7: Exercises.ExerciseOne(); break;
                        case 8: Exercises.ExerciseTwo(); break;
                        case 9: Exercises.ExerciseThree(); break;
                        case 10: Exercises.ExerciseFour(); break;
                        case 11: Exercises.ExerciseFive(); break;
                        case 12: Exercises.ExerciseSix(); break;
                        case 13: Exercises.ExerciseSeven(); break;
                        case 14: Exercises.ExerciseEigth(); break;
                        case 15: Exercises.ExerciseNine(); break;
                        case 16: Exercises.ExerciseTen(); break;
                        case 17: Exercises.ExerciseEleven(); break;
                        case 18: Exercises.ExerciseTwelve(); break;
                        case 19: Exercises.ExerciseThirdteen(); break;
                        default:
                            ErrorManager.PrintError(ErrorManager.NotValidMsg);
                            break;
                    }
                    if (!exit)
                    {
                        Console.ReadKey();
                    }
                }
                catch (IOException)
                {
                    ErrorManager.PrintError(ErrorManager.IOErrorMsg);
                    Console.ReadKey();
                }
                catch (ArgumentNullException)
                {
                    ErrorManager.PrintError(ErrorManager.ArgumentNullErrorMsg);
                    Console.ReadKey();
                }
                catch (OverflowException)
                {
                    ErrorManager.PrintError(ErrorManager.OverFlowErrorMsg);
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    ErrorManager.PrintError(ErrorManager.FormatExceptionErrorMsg);
                    Console.ReadKey();
                }
                catch (IndexOutOfRangeException)
                {
                    ErrorManager.PrintError(ErrorManager.IndexOutOfRangeMsg);
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    ErrorManager.PrintError(ErrorManager.UnknownError);
                    Console.ReadKey();
                }
            }
        }
    }
}
