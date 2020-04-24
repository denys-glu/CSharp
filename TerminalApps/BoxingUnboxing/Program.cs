using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");
            var sum = new int();
            foreach(var item in myList){
                if(item is int) {
                    sum += (int)item;
                }
                // System.Console.WriteLine(item);
            }
            System.Console.WriteLine(sum);
        }
    }
}

// Create an empty List of type object
//  Add the following values to the list: 7, 28, -1, true, "chair"
//  Loop through the list and print all values (Hint: Type Inference might help here!)
//  Add all values that are Int type together and output the sum