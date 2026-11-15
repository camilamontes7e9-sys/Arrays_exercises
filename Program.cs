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
                        case 1: Array_Exs.ExerciseOne(); break;
                        case 2: Array_Exs.ExerciseTwo(); break;
                        case 3: Array_Exs.ExerciseThree(); break;
                        case 4: Array_Exs.ExerciseFour(); break;
                        case 5: Array_Exs.ExerciseFive(); break;
                        case 6: Array_Exs.ExerciseSix(); break;
                        case 7: Matrix_Exs.ExerciseOne(); break;
                        case 8: Matrix_Exs.ExerciseTwo(); break;
                        case 9: Matrix_Exs.ExerciseThree(); break;
                        case 10: Matrix_Exs.ExerciseFour(); break;
                        case 11: Matrix_Exs.ExerciseFive(); break;
                        case 12: Matrix_Exs.ExerciseSix(); break;
                        case 13: Matrix_Exs.ExerciseSeven(); break;
                        case 14: Matrix_Exs.ExerciseEigth(); break;
                        case 15: Matrix_Exs.ExerciseNine(); break;
                        case 16: Matrix_Exs.ExerciseTen(); break;
                        case 17: Matrix_Exs.ExerciseEleven(); break;
                        case 18: Matrix_Exs.ExerciseTwelve(); break;
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
            catch (Exception)
            {
                ErrorManager.PrintError(ErrorManager.UnknownError);
            }
        }
    }
}