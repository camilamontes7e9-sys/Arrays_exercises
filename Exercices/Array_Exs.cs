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
            const string InitialMsg = "Enter 5 grades of your choice, then it prints also the approved ones";
            const string InputMsg = "Enter a grade: ";
            const string AllNotesMsg = "The grades are: ";
            const string ApprovedNotesMsg = "THe approved grades are: ";
            const double MinApproved = 5;
            const int MaxNotes = 5;

            double inputNote; 
            int countApproved = 0;
            double[] notes = new double[MaxNotes];
            double[] approved = new double[MaxNotes];

            Console.WriteLine(InitialMsg);
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine(InputMsg);
                inputNote = double.Parse(Console.ReadLine());

                notes[i] = inputNote;
                if (notes[i] >= MinApproved)
                {
                    approved[countApproved] = notes[i];
                    countApproved++;
                }
            }

            Console.WriteLine(AllNotesMsg);
            foreach (double note in notes)
            {
                Console.Write($"{note}, ");
            }

            Console.WriteLine(ApprovedNotesMsg);
            foreach (double note in approved)
            {
                if (note != 0)
                {
                    Console.Write($"{note}, ");
                }
            }

        }
        public void ExerciseThree()
        {
            const string ArrayMsg = "The array constains: ";
            const string BackArrayMsg = "The array backwards: ";
            const int ArraySize = 5;

            int[] numbers = new int[ArraySize];

            Console.WriteLine(ArrayMsg);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
                Console.Write($"{numbers[i]}, ");
            }

            Console.WriteLine($"\n {BackArrayMsg}");
            for(int i = numbers.Length - 1; i > -1; i--)
            {
                Console.Write($"{numbers[i]}, ");
            }

        }
        public void ExerciseFour()
        {
            const string ArrayMsg = "The array constains: ";
            const string InputMsg = "Enter the number you want to know the position in the array: ";
            const string NumFoundMsg = "The number {0} apears in position {1}";
            const string NotFoundMsg = "The number does not appear in the array"; 
            const int ArraySize = 10;

            Random rnd = new Random();
            int[] numbers = new int[ArraySize];
            int input;
            bool NumFound = false;

            Console.WriteLine(ArrayMsg);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-50, 101);
                Console.Write($"{numbers[i]}, ");
            }

            Console.WriteLine($"\n {InputMsg}");
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == input)
                {
                    Console.WriteLine(NumFoundMsg, numbers[i], i);
                    NumFound = true;
                }
            }

            if (!NumFound)
            {
                Console.WriteLine(NotFoundMsg);
            }

        }
        public void ExerciseFive()
        {
            const int MatrixSize = 10;

            int[,] table = new int[MatrixSize, MatrixSize];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for(int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (i+1) * (j+1);
                    Console.Write($"{table[i, j]}");
                }
                Console.WriteLine("");
            }

        }

        public void ExerciseSix()
        {

        }
    }
}
