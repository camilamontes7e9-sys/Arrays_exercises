using Activities_;
using Array_Exercices.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Exercises.Exercices
{
    public class Matrix_Exs
    {
        public static Random rnd = new Random();
        public static void ExerciseOne()
        {
            const string ArrayMsg = "Array filled with randoms numbers:";
            const string OddArrayMsg = "Odds numbers of the array:";
            const string EvenArrayMsg = "Even numbers of the array:";

            const int ArrayLength = 10;

            int[] numbers = new int[ArrayLength];
            int[] oddNum = new int[ArrayLength];
            int[] evenNum = new int[ArrayLength];

            int evenCount = 0, oddCount = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-50, 101);

                if (numbers[i] % 2 == 0)
                {
                    evenNum[evenCount] = numbers[i];
                    evenCount++;
                }
                else
                {
                    oddNum[oddCount] = numbers[i];
                    oddCount++;
                }
            }

            Console.WriteLine(ArrayMsg);

            foreach (int num in numbers)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();
            Console.WriteLine(OddArrayMsg);
            foreach (int num in oddNum)
            {
                if (num != 0)
                {
                    Console.Write($"{num}, ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(EvenArrayMsg);

            foreach (int num in evenNum)
            {
                if (num != 0)
                {
                    Console.Write($"{num}, ");
                }
            }

        }
        public static void ExerciseTwo()
        {
            string[] pokemonList = {
                "Pikachu", "Charmander",
                "Squirtle", "Bulbasaur",
                "Eevee", "Jigglypuff",
                "Meowth", "Psyduck",
                "Snorlax", "Gengar",
                "Machop", "Magikarp",
                "Vulpix", "Onix", "Abra"
            };

            string input = "";


            while (input != "0")
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- List pokémons");
                Console.WriteLine("0- Exit");
                Console.Write("> ");


                input = Console.ReadLine();

                switch (input)
                {
                    case "1": break;
                }

                if (input == "1")
                {
                    Console.WriteLine("\nYour Pokédex contains:");
                    for (int i = 0; i < pokemonList.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {pokemonList[i]}");
                    }


                    Console.WriteLine("\nWhich Pokémon do you want to release? Enter the index:");
                    Console.Write("> ");


                    if (int.TryParse(Console.ReadLine(), out int indexUsuario))
                    {
                        int indexArray = indexUsuario - 1;


                        if (indexArray >= 0 && indexArray < pokemonList.Length)
                        {
                            if (pokemonList[indexArray] == "Empty")
                            {
                                Console.WriteLine($"The index {indexUsuario} is empty. There's no Pokémon in that slot to release.");
                            }
                            else
                            {
                                Console.WriteLine($"You released {pokemonList[indexArray]}!");
                                pokemonList[indexArray] = "Empty";
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid index. Please enter a number between 1 and 15.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid number.");
                    }
                }
                else if (input != "0")
                {
                    Console.WriteLine("\nInvalid option.");
                }
            }

        }
        public static void ExerciseThree()
        {

        }
        public static void ExerciseFour()
        {

        }
        public static void ExerciseFive()
        {

        }
        public static void ExerciseSix()
        {

        }
        public static void ExerciseSeven()
        {

        }
        public static void ExerciseEigth()
        {

        }
        public static void ExerciseNine()
        {

        }
        public static void ExerciseTen()
        {

        }

        public static void ExerciseEleven()
        {
            const string InputMsg = "Enter the message: ";
            const string censored = "****";
            const int ArrayLength = 6;

            string input, convertedInput;
            string[] prohibitedWords = new string[ArrayLength] {
         "noob", "uninstall", "trash", "ez", "nigger", "nigga" };

            Console.WriteLine(InputMsg);
            input = Console.ReadLine();
            convertedInput = input.ToLower();

            for (int i = 0; i < prohibitedWords.Length; i++)
            {
                if (convertedInput.Contains(prohibitedWords[i]))
                {
                    convertedInput = convertedInput.Replace(prohibitedWords[i], censored);
                }
            }

            Console.WriteLine(convertedInput);
        }
        public static void ExerciseTwelve()
        {
            const string InputMsg = "Enter a valid password";
            const string TryAgainMsg = "Please try again";

            string input = "";
            bool isValid = true;
            int inputSize;

            Console.WriteLine(InputMsg);
            input = Console.ReadLine();
            inputSize = input.Length;


            while (isValid && input != "0")
            {
                if (input.Length < 3 && input.Length > 16)
                {
                    ErrorManager.PrintError(ErrorManager.PassWordOutOfRange);
                    Console.WriteLine(TryAgainMsg);
                }
                else if (input.EndsWith(" "))
                {
                    ErrorManager.PrintError(ErrorManager.PassWordOutOfRange);
                }


            }

        }
    }
}
