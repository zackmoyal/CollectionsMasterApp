﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
            Console.WriteLine($"First number: {numbers[0]}");

            //TODO: Print the last number of the array
            Console.WriteLine($"Last number: {numbers[numbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            // 1)
            Array.Reverse(numbers);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbers);

            // 2)
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine();
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> numberList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"List Capacity: {numberList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //TODO: Print the new capacity
            Console.WriteLine($"New List Capacity: {numberList.Capacity}");
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userNumber = int.Parse(Console.ReadLine());
            NumberChecker(numberList, userNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Create a method that will remove all odd numbers from the list then print results
            OddKiller(numberList);
            Console.WriteLine("Evens Only!!");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            numberList.Sort();
            Console.WriteLine("Sorted Evens!!");
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArray = numberList.ToArray();

            //TODO: Clear the list
            numberList.Clear();

            Console.WriteLine("List Cleared!");
            Console.WriteLine("------------------");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Number found.");
            }
            else
            {
                Console.WriteLine("Number not found.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                int rando = rng.Next(50);
                numberList.Add(rando);
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
