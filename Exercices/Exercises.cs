using Activities_;
using Array_Exercices.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
                Console.Write($"{numbers[i]}, ");
            }

            Console.Write(BackArrayMsg);
            for (int i = ArrayLength - 1; i > 0; i--)
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

            if (count > 0)
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
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int aux = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
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
            const int MinLvlMin = 1, MinLvlMax = 11;
            const int PowerMin = 100, PowerMax = 501;
            const int CostSize = 200, WeigthSize = 10;
            const int ItemSize = 4, ItemNameSize = 7;
            const int LevelSize = 11, RareType = 4;

            string[] itemNames = new string[ItemNameSize]
            {
                "NAME", "LEVEL MIN", "POWER", "WEIGHT", "COST", "RARE ITEM", "RARE TYPE"
            };

            string[] items = new string[ItemSize] { "SWORD", "SHIELD", "POTION", "ARCH" };
            string[] rareTypes = new string[RareType] {"Rare", "Comun", "Legendary", "Ordinary" };
            int[] levels = new int[LevelSize];

            int minLevel, power;
            double weight, cost;
            string rareType, item;
            bool isRareItem;

            foreach (string name in itemNames)
            {
                Console.Write($"{name}  ");
            }

            Console.WriteLine($"\n{PrintManager.Space}{PrintManager.Space}");

            for (int i = 0; i < items.Length; i++)
            {
                item = items[i];
                minLevel = rnd.Next(MinLvlMin, MinLvlMax);
                power = rnd.Next(PowerMin, PowerMax);
                weight = Math.Round(rnd.NextDouble() * WeigthSize, 1);
                cost = Math.Round(rnd.NextDouble() * CostSize, 2);
                isRareItem = rnd.Next(2) == 1;

                if (isRareItem)
                {
                    rareType = rareTypes[rnd.Next(3)];
                }
                else
                {
                    rareType = rareTypes[rareTypes.Length];
                }
                Console.WriteLine($"{items[i]}\t{minLevel}\t{power}\t{weight}kg\t{cost}€\t{isRareItem}\t{rareType}");
                rareType = "";
            }
        }
        public static void ExerciseSix()
        {
            const int TropesSize = 10, MapSize = 5, regionOneSize = 4, regionTwoSize = 2, regionThreeSize = 3;

            string[] tropes = new string[TropesSize];
            string[,] map = new string[MapSize, MapSize];
            string[][] regions =
            {
                new string[regionOneSize],
                new string[regionTwoSize],
                new string[regionThreeSize]
            };

            for(int i = 0; i < tropes.Length; i++)
            {
                if (i % 2 == 0)
                {
                    tropes[i] = "🛡️";
                }
                else
                {
                    tropes[i] = "⚔️";
                }
                Console.Write($"{tropes[i]} ");
            }
            Console.WriteLine("\n");

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if(i % 2 == 0 && j % 2 == 0)
                    {
                        map[i, j] = "🗼";
                    }
                    else if (i % 2 != 0 && j % 2 != 0)
                    {
                        map[i, j] = "🕳️";
                    }
                    else
                    {
                        map[i, j] = "🌿";
                    }
                    Console.Write($"{map[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            for(int i = 0; i < regions.Length; i++)
            {
                for (int j = 0; j < regions[i].Length; j++)
                {
                    if((i + j) % 2 == 0)
                    {
                        regions[i][j] = "➖";
                    }
                    else
                    {
                        regions[i][j] = "💎";
                    }
                    Console.Write($"{regions[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void ExerciseSeven()
        {
            const string InitialMsg = "Welcome to the treasure explorer game! \r" +
                "\nA 10x10 map with hidden treasures has been generated, and you have 3 attempts to collect as many diamonds as possible…";
            const int MapSize = 10, RandomChance = 2;

            string[,] map = new string[MapSize, MapSize];

            int randomNum, tries = 0;
            string input;
            bool exit = false;

            Console.WriteLine(InitialMsg);

            while (!exit || tries == 3)
            {
                PrintManager.PrinteMenuExSeven();
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        for (int i = 0; i < map.GetLength(0); i++)
                        {
                            for (int j = 0; j < map.GetLength(1); j++)
                            {
                                randomNum = rnd.Next(RandomChance);

                                if (randomNum == 0)
                                {
                                    map[i, j] = "0";
                                }
                                else
                                {
                                    map[i, j] = "*";
                                }


                            }
                        }
                        break;
                    case "0": exit = true; break;
                }

            }
           
            

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
            const string RecordMsg = "The record of the damage: {0}";
            const string ReportMsg = "The report:";
            const int RecordSize = 5;

            string[] record = new string[RecordSize]
            {
                "Link hits Ganon for 35 damage",
                "Ganon hits Link for 20 damage",
                "Link hits Ganon for 50 damage",
                "Zelda hits Ganon for 40 damage",
                "Ganon hits Zelda for 25 damage"
            };

            int maxDmg = 0;
            string mvp = "";

            foreach (string line in record)
            {
                Console.WriteLine(line);
            }

            string[] names = new string[3] { "Link", "Zelda", "Ganon" };

            int[][] characters =
            {
                new int[] { 0, 0 }, // Link
                new int[] { 0, 0 }, // Zelda
                new int[] { 0, 0 }  // Ganon
            };

            foreach (string msg in record)
            {
                string[] line = msg.Split(' ');

                for(int i = 0; i < characters.Length; i++)
                {
                    int damage = Convert.ToInt32(line[4]);

                    if (line[0] == names[i])
                    {
                        characters[i][0] += damage;
                    }

                    if (line[2] == names[i])
                    {
                        characters[i][1] += damage;
                    }

                }

                for (int i = 0; i < characters.Length; i++)
                {
                    if (characters[i][0] > maxDmg)
                    {
                        maxDmg = characters[i][0];
                        mvp = names[i];
                    }
                }
            }

            Console.WriteLine($"\n{ReportMsg}");
            Console.WriteLine(DamageDoneMsg, characters[0][0], characters[1][0], characters[2][0]);
            Console.WriteLine(DamageReceivedMsg, characters[0][1], characters[1][1], characters[2][1]);
            Console.WriteLine(RecordMsg, mvp);
        }
    }
}
