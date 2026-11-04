using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Activities_;

namespace Array_Exercises.Exercices
{
    public class Array_Exs
    {
        const string Space = "----------------------------";
        public void ExerciseOne()
        {
            const string ArrayMsg = "Array filled with randoms numbers:";
            const string OddArrayMsg = "Odds numbers of the array:";
            const string EvenArrayMsg = "Even numbers of the array:";
            const string AverageMsg = "The average number is:";
            const string MinNumMsg = "The minimum number among all is:";
            const string MaxNumMsg = "The maximum number among all is:";
            const int ArrayLength = 10;

            int[] numbers = new int[ArrayLength];
            int[] oddNum = new int[ArrayLength];
            int[] evenNum = new int[ArrayLength];

            Random rnd = new Random();
            int evenCount = 0, oddCount = 0, average = 0, minValue = 0, maxValue = 0;


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

                average += numbers[i];

                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
                else if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }

            }

            average /= ArrayLength; 

            Console.WriteLine(ArrayMsg);

            foreach (int num in numbers)
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine();
            Console.WriteLine($"{Space} \n{AverageMsg} {average} \n{MinNumMsg} {minValue} \n{MaxNumMsg} {maxValue} \n{Space}");

            Console.WriteLine(OddArrayMsg);

            foreach (int num in oddNum)
            {
                if(num != 0)
                {
                    Console.Write($"{num}, ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(EvenArrayMsg);

            foreach(int num in evenNum)
            {
                if (num != 0)
                {
                    Console.Write($"{num}, ");
                }
            }

        }
        public void ExerciseTwo()
        {

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
    }
}
