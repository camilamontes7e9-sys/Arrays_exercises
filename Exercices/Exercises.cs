using Activities_;
using Array_Exercices.Helpers;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Array_Exercises.Exercices
{
    public class Exercises
    {
        public static Random rnd = new Random();
        public static void ExerciseOne()
        {
            const string ArrayMsg = "Array filled with randoms numbers:";
            const string OddArrayMsg = "Odds numbers of the array:";
            const string EvenArrayMsg = "Even numbers of the array:";

            const int ArrayLength = 10, MinNum = -50, MaxNum = 101;

            int[] numbers = new int[ArrayLength];
            int[] oddNum = new int[ArrayLength];
            int[] evenNum = new int[ArrayLength];

            int evenCount = 0, oddCount = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(MinNum, MaxNum);

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
            const string InitialMsg = "Choose an option:";
            const string OptionOneMsg = "1. List pokémons";
            const string ExitOptionMsg = "0. Exit\n";
            const string PokedexMsg = "Your Pokédex contains:";
            const string RelasePokeMsg = "Enter which Pokémon you want to relase: ";
            const string NotPokemonMsg = "The slot {0} is empty. There's no Pokémon to release";
            const string RelasedPokeMsg = "You released {0} pokémon!";
            const string EmptyMsg = "---";

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
                Console.WriteLine(InitialMsg);
                Console.WriteLine(OptionOneMsg);
                Console.WriteLine(ExitOptionMsg);


                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine($"\n{PokedexMsg}\n");

                    for (int i = 0; i < pokemonList.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {pokemonList[i]}");
                    }

                    Console.WriteLine($"\n{RelasePokeMsg}");

                    string userInput = Console.ReadLine();

                    int indexArray = Convert.ToInt32(userInput) - 1;


                    if (indexArray < pokemonList.Length)
                    {
                        if (pokemonList[indexArray].Contains(EmptyMsg))
                        {
                            Console.WriteLine(NotPokemonMsg, userInput);
                        }
                        else
                        {
                            Console.WriteLine(RelasedPokeMsg, pokemonList[indexArray]);
                            pokemonList[indexArray] = EmptyMsg;
                        }
                    }
                    else
                    {
                        ErrorManager.PrintError(ErrorManager.IndexOutOfRangeMsg);
                    }
                }
                else if (input != "0")
                {
                    ErrorManager.PrintError(ErrorManager.InvalidMsg);
                }
            }

        }
        public static void ExerciseThree()
        {
            const string ArrayMsg = "The generated array: ";
            const string BackArrayMsg = "\nThe array backwards: ";

            const int ArrayLength = 10;

            int[] numbers = new int[ArrayLength];

            Console.Write(ArrayMsg);
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
                Console.Write($"{numbers[i]}, ");
            }

            Console.Write(BackArrayMsg);
            for (int i = ArrayLength -1; i > 0; i--)
            {
                Console.Write($"{numbers[i]}, ");
            }

        }
        public static void ExerciseFour()
        {
            const string ArrayMsg = "The generated array: ";
            const string SortedMsg = "Sorted Array: ";
            const string SearchMsg = "Enter which number you want to search: ";
            const string NumTimesMsg = "The number {0} appears {1} times";
            const string GeneratedMsg = "The array has been generated... ";
            const string AppearsMsg = "The number {0} does not appear on the array";

            const int ArrayLength = 10, MinNum = 1, MaxNum = 10;

            int[] numbers = new int[ArrayLength];
            int input, count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(MinNum, MaxNum);
            }

            Console.WriteLine(GeneratedMsg);
            Console.ReadKey();

            Console.WriteLine(SearchMsg);
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == input)
                {
                    count++;
                }
            }

            if(count > 0)
            {
                Console.WriteLine(NumTimesMsg, input, count);
            }
            else
            {
                Console.WriteLine(AppearsMsg, input);
            }
            

            Console.Write(ArrayMsg);
            foreach (int num in numbers)
            {
                Console.Write($"{num}, ");
            }

            //BubbleSort
            for (int i = 1; i < numbers.Length; i++)
            {
                for(int j = 0; j < numbers.Length -1; j++) 
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        int aux = numbers[j+1];
                        numbers[j+1] = numbers[j];
                        numbers[j] = aux;
                    }
                }
            }

            Console.Write($"\n{SortedMsg}");
            foreach (int num in numbers)
            {
                Console.Write($"{num}, ");
            }

        }
        public static void ExerciseFive()
        {
            const string ShopMsg = "=============== AVALIBLE ITEMS ON THE SHOP ===============";
            const int ItemSize = 4, ItemNameSize = 7;
            const int MinLevelSize = 1, MaxLevelSize = 11;

            string[] itemNames = new string[ItemNameSize] 
            { 
                "   NAME   ", "LEVEL MIN", "POWER", "WEIGHT", "COST", "RARE ITEM", "RARE TYPE" 
            };

            string[] items = new string[ItemSize] { "SWORD", "SHIELD", "POTION","ARCH" };
            int[] levels = new int[MaxLevelSize];


            foreach(string name in itemNames)
            {
                Console.WriteLine($"{name}\t");
            }

            Console.Write(items[0]);




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
            string[] prohibitedWords = new string[ArrayLength] 
            {
                "noob", "uninstall", "trash", "ez", "nigger", "nigga" 
            };

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

        public static void ExerciseThirdteen()
        {
            const string DamageDoneMsg = "Damage done: Link {0} | Zelda {1} | Ganon {2}";
            const string DamageReceivedMsg = "Damage received: Link {0} | Zelda {1} | Ganon {2}";
            const string RecordMsg = "The record of the damage: ";
            const string ReportMsg = "The report:";
            const int RecordSize = 5, DmgSize = 3;

            string[] record = new string[RecordSize]
            {
                "Link hits Ganon for 35 damage",
                "Ganon hits Link for 20 damage",
                "Link hits Ganon for 50 damage",
                "Zelda hits Ganon for 40 damage",
                "Ganon hits Zelda for 25 damage"
            };

            int[] damage = new int[RecordSize];
            int[] damageDone = new int[DmgSize];
            int[] damageReceived = new int[DmgSize];

            int higherDmg = 0;

            Console.WriteLine(RecordMsg);
            foreach (string msg in record)
            {
                Console.WriteLine(msg);
            }

            for (int i = 0; i < record.Length; i++)
            {
                var a = record[i].Where(char.IsDigit);
                var number = Convert.ToInt32(record[i].Where(char.IsDigit).ToString());
                damage[i] = number;
            }

            damageDone[0] = damage[0] + damage[2];
            damageDone[1] = damage[3];
            damageDone[2] = damage[1] + damage[4];

            damageReceived[0] = damage[1];
            damageReceived[1] = damage[4];
            damageReceived[2] = damage[0] + damage[2] + damage[3];

            for (int i = 0; i < damageDone.Length; i++)
            {
                if (higherDmg < damage[i])
                {
                    higherDmg = damage[i];
                }
            }

            

            Console.WriteLine(ReportMsg);

            Console.Write(DamageDoneMsg);
            for (int i = 0; i < damageReceived.Length; i++)
            {
                Console.Write(damageReceived[i]);
            }




        }
    }
}
