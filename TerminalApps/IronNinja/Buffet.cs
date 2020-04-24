using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu = new List<IConsumable>();

        //constructor
        public Buffet(){}

        public void AddToMenu(IConsumable item) {
            Menu.Add(item);
        }

        public void ShowMenu(){
            int i = 1;
            foreach (IConsumable item in Menu){
                System.Console.WriteLine($"#{i}: {item.Name} (Food).\n Calories: {item.Calories}.\n  Spicy?: {item.IsSpicy},\n Sweet?: {item.IsSweet}");
                i++;
            }
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            IConsumable randomDish = Menu[rand.Next(0, Menu.Count)];
            System.Console.WriteLine("Random dish: " + randomDish.Name);
            return randomDish;
            // return Menu[rand.Next(0,7)];
        }
    }
}