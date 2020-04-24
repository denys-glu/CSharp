using System;
using System.Collections.Generic;
namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Samurai = new Ninja();
            Buffet Pho = new Buffet();
            Samurai.Eat(Pho.Serve());
            Samurai.Eat(Pho.Serve());
            Samurai.Eat(Pho.Serve());
            Samurai.Eat(Pho.Serve());
        }
        class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food(string name, int calories, bool isSpicy, bool isSweet){
                Name = name;
                Calories = calories;
                IsSpicy = isSpicy;
                IsSweet = isSweet;
            }
        }
        class Buffet
        {
            public List<Food> Menu;
             
            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Rice", 300, true, false),
                    new Food("Banana", 300, false, true),
                    new Food("Chocolate Cake", 700, false, true),
                    new Food("Borcsh", 600, false, false),
                    new Food("Lasagna", 600, false, false),
                    new Food("Ramen", 400, true, false),
                    new Food("Burger", 800, false, false)
                };
            }
             
            public Food Serve()
            {
                Random rand = new Random();
                Food randomDish = Menu[rand.Next(0,7)];
                System.Console.WriteLine("Random dish: " + randomDish.Name);
                return randomDish;
                // return Menu[rand.Next(0,7)];
            }
        }
        class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;
             
            // add a constructor
            public Ninja(){
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }
            // add a public "getter" property called "IsFull"
            public bool IsFull {
                get {
                    if(calorieIntake > 1200) {
                        return true;
                    } else {
                        return false;
                    }
                }
            }
            // build out the Eat method
            public void Eat(Food item)
            {
                if(IsFull) {
                    System.Console.WriteLine("This Ninja is Full, it will explode if you will cointinue like that...");
                } else {
                    calorieIntake += item.Calories;
                    FoodHistory.Add(item);
                    System.Console.WriteLine($"Food name is: {item.Name}, spicy: {item.IsSpicy}, sweet: {item.IsSweet}.");
                }
            }
        }
            // add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
            // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
            // build out the Eat method that: if the Ninja is NOT full
                // adds calorie value to ninja's total calorieIntake
                // adds the randomly selected Food object to ninja's FoodHistory list
                // writes the Food's Name - and if it is spicy/sweet to the console
            // if the Ninja IS full
                // issues a warning to the console that the ninja is full and cannot eat anymore
    }
}
