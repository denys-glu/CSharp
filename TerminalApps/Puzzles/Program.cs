using System;
using System.Collections.Generic;
namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // System.Console.WriteLine(TossCoin());
            // System.Console.WriteLine(TossMultipleCoins(3));
            System.Console.WriteLine(Names());
        }

        public static Random rand = new Random();
        public static int[] RandomArray()
        {
            int[] numbers = new int[10];
            int minValue = rand.Next(5, 25);
            int maxValue = numbers[0];
            int sum = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(5, 25);
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                }
                if (maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                }
                sum += numbers[i];
            }

            System.Console.WriteLine($"Min value is: {minValue}, Max value is: {maxValue} and sum of all values is: {sum}");
            return numbers;
        }

        public static string TossCoin()
        {
            byte side = (byte)rand.Next(0, 2);
            if (Convert.ToBoolean(side))
            {
                System.Console.WriteLine("Heads!");
                return "Heads";
            }
            System.Console.WriteLine("Tails!");
            return "Tails";
        }

        public static double TossMultipleCoins(int num)
        {
            int headToss = 0;
            int tails = 0;
            int counter = num;
            while (num > 0)
            {
                if (TossCoin() == "Heads")
                {
                    headToss += 1;
                }
                else
                {
                    tails += 1;
                }
                num--;
            }
            return (double)headToss / counter;
        }

        public static List<string> Names()
        {
            List<string> myList = new List<string>();
            List<string> shortNames = new List<string>();

            myList.Add("Todd");
            myList.Add("Tiffany");
            myList.Add("Charlie");
            myList.Add("Geneva");
            myList.Add("Sydney");

            for (var i = 0; i < myList.Count; i++)
            {
                int k = rand.Next(i);
                var temp = myList[k];
                myList[k] = myList[i];
                myList[i] = temp;

            }

            for (var i = 0; i < myList.Count; i++)
            {
                if (myList[i].Length > 5)
                {
                    shortNames.Add(myList[i]);
                }
            }


            // for (var i = 0; i < shortNames.Count; i++)
            // {
            //     System.Console.WriteLine(shortNames[i]);
            // }
            return shortNames;
        }
    }
}
// Names
// Build a function Names that returns a list of strings.  In this function:
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Shuffle the list and print the values in the new order
// Return a list that only includes names longer than 5 characters

// Random Array
// Create a function called RandomArray() that returns an integer array
// Place 10 random integer values between 5-25 into the array
// Print the min and max values of the array
// Print the sum of all the values

// Coin Flip
// Create a function called TossCoin() that returns a string
// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin 
// Have the function print either "Heads" or "Tails"
// Finally, return the result
// Create another function called TossMultipleCoins(int num) that returns a Double
// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss
