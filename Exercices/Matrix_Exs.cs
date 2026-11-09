using System;
using System.Collections.Generic;
using System.Text;
using Activities_;

namespace Array_Exercises.Exercices
{
    public class Matrix_Exs
    {
        public static Random rnd = new Random();
        public void ExerciseOne()
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
        public void ExerciseTwo()
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

            string opcion = "";


            while (opcion != "0")
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Llistar pokémons");
                Console.WriteLine("0- Exit");
                Console.Write("> ");


                opcion = Console.ReadLine();


                if (opcion == "1")
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
                else if (opcion != "0")
                {
                    Console.WriteLine("\nInvalid option.");
                }
            }

        }
        public void ExerciseThree()
        {

        }
        public void ExerciseFour()
        {

        }
        public void ExerciseFive()
        {

        }
        public void ExerciseSix()
        {

        }
        public void ExerciseSeven()
        {

        }
        public void ExerciseEigth()
        {

        }
        public void ExerciseNine()
        {

        }
        public void ExerciseTen()
        {

        }
    }
}
