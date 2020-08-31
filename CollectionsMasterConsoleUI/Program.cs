using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] myArray = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray);


            //Print the first number of the array
            Console.WriteLine(myArray[0]);


            //Print the last number of the array
            Console.WriteLine(myArray[49]);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(myArray);
            NumberPrinter(myArray);
           
            Console.WriteLine("-------------------");
            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(myArray);

            Console.WriteLine("-------------------");


            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);
            NumberPrinter(myArray);
            

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);
            NumberPrinter(myArray);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

        

           
            








            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List

            List<int> numberList = new List<int>();


            //Print the capacity of the list to the console

            Console.WriteLine($"List starting capacity: {numberList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //Print the new capacity
            Console.WriteLine($"List capacity after population: {numberList.Capacity}");


            

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the list?");
            int searchNumber = int.Parse(Console.ReadLine());
            NumberChecker(numberList, searchNumber);

            Console.WriteLine("-------------------");
         
            

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numberList);

            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);


            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable

            var arrayFromList = numberList.ToArray();


            //Clear the list
            numberList.Clear();
            

            #endregion
        }

        private static void Populater(int[] myArray)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                myArray[i] = rng.Next(0, 50);
            }

        }

        private static void ThreeKiller(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 3 == 0)
                {
                    myArray[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 ==0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("\n Number Found!!\n");
            }
            else
            {
                Console.WriteLine("404 NOT FOUND");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(i);
            }
        }


        private static void ReverseArray(int[] myArray)
        {
            Array.Reverse(myArray);
            NumberPrinter(myArray);
            
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
    














