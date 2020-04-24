using System;

namespace IronNinja
{
    // Create a Drink class that implements the IConsumable interface. Make sure Drink objects are always sweet.
    class Drink : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
        
        public Drink(string name, int cal, bool spicy) {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = true;
        }
        public string GetInfo(){
            return $"{Name} (Food).\n Calories: {Calories}.\n  Spicy?: {IsSpicy},\n Sweet?: {IsSweet}";
        }
        
        // Implement a GetInfo Method
        // Add a constructor method
    }
}