using System;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                int caloriesToAdd = item.Calories;
                if (item.IsSweet)
                {
                    caloriesToAdd += 10;
                }
                calorieIntake += caloriesToAdd;
                ConsumptionHistory.Add(item);
                System.Console.WriteLine(item.GetInfo());
            }

            // provide override for Consume
        }
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1500)
                {
                    System.Console.WriteLine($"Dude i'm full, i've already ate like {calorieIntake} calories");
                    return true;
                }
                System.Console.WriteLine("I can eat more!!");
                return false;
            }
        }
    }
}

// Make a child class of Ninja, for a SweetTooth. A SweetTooth should be "full" at 1500 calories. When a SweetTooth "Consumes":

// If NOT Full
// adds calorie value to SweetTooth's total calorieIntake (+10 additional calories if the consumable item is "Sweet")
// adds the randomly selected IConsumable object to SweetTooth's ConsumptionHistory list
// calls the IConsumable object's GetInfo() method
// If Full
// issues a warning to the console that the SweetTooth is full and cannot eat anymore