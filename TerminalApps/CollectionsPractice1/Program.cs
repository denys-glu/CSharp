using System;
using System.Collections.Generic;
namespace CollectionsPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays
            // var arr = new int[10] {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            // var boolean = new bool[10] {true, false, true, false, true, false, true, false, true, false};

            //  Lists
            List<string> iceCreamFlavors = new List<string> () {"chocolate", "mango", "french vanilla", "oreo"};
            // System.Console.WriteLine("List count: " + iceCreamFlavors.Count);
            // iceCreamFlavors.RemoveAt(2);
            // System.Console.WriteLine("List count: " + iceCreamFlavors.Count);

            // Dictionary
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            Random rand = new Random();
            for ( int i = 0; i < names.Length; i++) {
                myDictionary.Add(names[i], iceCreamFlavors[rand.Next(0, iceCreamFlavors.Count)]);
            }

            foreach (KeyValuePair<string, string> item in myDictionary){
                System.Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
// Exercises:
// Three Basic Arrays
// Create an array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array of length 10 that alternates between true and false values, starting with true

// List of Flavors
// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
// Output the length of this list after building it
// Output the third flavor in the list, then remove this value
// Output the new length of the list (It should just be one fewer!)

// User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly select a flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor