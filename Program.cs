using System;
using Array_Exercises.Exercices;
using Array_Exercises;

namespace Activities_
{
    public class Program
    {
        public static void Main()
        {
            const string Menu = "------------MENU------------";
            const string InitialMsg = "To access an activity enter wich one you want to access: ";
            const string MenuMsg = "Exercise {0} (Arrays): ";
            const string MenuMsgTwo = "Exercise {0} (Matrix): ";
            const string ExitMsg = "Enter 0 to exit: ";
            const string Space = "----------------------------";
            const int AuxNum = 7, AuxNumTwo = 9;

            var matrix_Exs = new Matrix_Exs();
            var array_Exs = new Array_Exs();
            var errorManager = new ErrorManager();

            string input = "";
            int convertedInput;

            try
            {
                Console.WriteLine($"\n{Menu} \n{InitialMsg} \n{Space}");

                for (int i = 1; i < AuxNum; i++)
                {
                    Console.WriteLine(MenuMsg, i);
                }

                Console.WriteLine(Space);

                for (int i = 1; i < AuxNumTwo; i++)
                {
                    Console.WriteLine(MenuMsgTwo, i);
                }

                input = Console.ReadLine();

                convertedInput = int.Parse(input);

                while (convertedInput != 0)
                {
                    switch (convertedInput)
                    {
                        case 1: array_Exs.ExerciseOne(); break;
                        case 2: array_Exs.ExerciseTwo(); break;
                        case 3: array_Exs.ExerciseThree(); break;
                        case 4: array_Exs.ExerciseFour(); break;
                        case 5: array_Exs.ExerciseFive(); break;
                        case 6: array_Exs.ExerciseSix(); break;
                        case 7: matrix_Exs.ExerciseOne(); break;
                        case 8: matrix_Exs.ExerciseTwo(); break;
                        case 9: matrix_Exs.ExerciseThree(); break;
                        case 10: matrix_Exs.ExerciseFour(); break;
                        case 11: matrix_Exs.ExerciseFive(); break;
                        case 12: matrix_Exs.ExerciseSix(); break;
                        case 13: matrix_Exs.ExerciseSeven(); break;
                        case 14: matrix_Exs.ExerciseEigth(); break;
                    }
                    convertedInput = int.Parse(Console.ReadLine());
                }
            }
            catch (IOException)
            {
                errorManager.PrintError(ErrorManager.IOErrorMsg);
            }
            catch (OutOfMemoryException)
            {
                errorManager.PrintError(ErrorManager.OutOfMemoryErrorMsg);
            }
            catch (ArgumentOutOfRangeException) 
            {
                errorManager.PrintError(ErrorManager.OutOfRangeErrorMsg);
            }
            catch (ArgumentNullException)
            {
                errorManager.PrintError(ErrorManager.ArgumentNullErrorMsg);
            }
            catch (Exception)
            {
                errorManager.PrintError(ErrorManager.UnknownError);
            }

            
        }

        
    }
}