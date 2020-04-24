using System;

namespace Basic13
{
    class Program
    {

        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (var i = 1; i < 256; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (var i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            var sum = 0;
            for (var i = 0; i < 256; i++)
            {
                sum += i;
                System.Console.WriteLine($"New number: {i}; Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            var maxNumber = numbers[0];
            foreach (var num in numbers)
            {
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            System.Console.WriteLine($"Max number is {maxNumber}");
            return maxNumber;
        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            System.Console.WriteLine($"Average nummber is: " + sum/numbers.Length);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            int odds = 0; 
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    odds += 1;
                }
            }
            int[] oddArray = new int[odds];
            for (int i = 0; i < oddArray.Length; i++)
            {
                    oddArray[i] = 2 * i + 1;
                    System.Console.WriteLine(2 * i + 1);
            }
            return oddArray;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            var counter = 0;
            foreach (var num in numbers) {
                if (num > y) {
                    counter += 1;
                }
            }
            System.Console.WriteLine(counter);
            return counter;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (var i = 0; i < numbers.Length; i++) {
                numbers[i] *= numbers[i];
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (var i = 0; i < numbers.Length; i++) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            var minValue = numbers[0];
            for (var i = 0; i < numbers.Length; i++) {
                if (minValue > numbers[i]) {
                    minValue = numbers[i];
                }
            }
            FindMax(numbers);
            GetAverage(numbers);
            System.Console.WriteLine($"Minimum value is: {minValue}");
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            var shifted = new int[numbers.Length];

            for (var i = 0; i < numbers.Length; i++) {
                if (i != numbers.Length - 1) {
                    shifted[i] = numbers[i+1];
                }
                System.Console.WriteLine(shifted[i]);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            var changed = new object[numbers.Length];
            for (var i = 0; i < numbers.Length; i++) {
                if ( numbers[i] < 0) {
                    changed[i] = "Dojo";
                } else {
                    changed[i] = numbers[i];
                }
                System.Console.WriteLine(changed[i]);
            }
            return changed;
        }
        static void Main(string[] args)
        {
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var mixeNumbersArray = new int[5] {1, 4, 0, -2, -3};
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(numbers);
            // FindMax(mixeNumbersArray);
            // GetAverage(numbers);
            OddArray();
            // GreaterThanY(numbers, 9);
            // SquareArrayValues(mixeNumbersArray);
            // EliminateNegatives(mixeNumbersArray);
            // MinMaxAverage(numbers);
            // ShiftValues(mixeNumbersArray);
            // NumToString(mixeNumbersArray);
        }
    }
}
