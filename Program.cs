using System;
using Array_Exercises.Exercices;
using Array_Exercices.Helpers;

namespace Activities_
{
    public class Program
    {
        public static void Main()
        {
            string input = "";
            int convertedInput;

            try
            {
                PrintManager.PrintMenu();

                input = Console.ReadLine();

                convertedInput = int.Parse(input);

                while (convertedInput != 0)
                {
                    switch (convertedInput)
                    {
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
                    }

                    Console.ReadKey();
                    PrintManager.PrintMenu();

                    convertedInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }
            }
            
            catch (IOException)
            {
                ErrorManager.PrintError(ErrorManager.IOErrorMsg);
            }
            catch (ArgumentNullException)
            {
                ErrorManager.PrintError(ErrorManager.ArgumentNullErrorMsg);
            }
            catch (OverflowException) 
            {
                ErrorManager.PrintError(ErrorManager.OverFlowErrorMsg);
            }
            catch (FormatException)
            {
                ErrorManager.PrintError(ErrorManager.FormatExceptionErrorMsg);
            }
            catch (IndexOutOfRangeException)
            {
                ErrorManager.PrintError(ErrorManager.IndexOutOfRangeMsg);
            }
            catch (Exception)
            {
                ErrorManager.PrintError(ErrorManager.UnknownError);
            }
        }
    }
}