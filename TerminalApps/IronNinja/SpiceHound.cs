using System;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (!IsFull) {
                if(item.IsSpicy) {
                    calorieIntake -= 5;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                System.Console.WriteLine(item.GetInfo());
            }
        }
        public override bool IsFull {
            get { 
                if ( calorieIntake > 1200 ) {
                    System.Console.WriteLine($"Dude i'm full, i've already ate like {calorieIntake} calories");
                    return true;
                }
                System.Console.WriteLine("I can eat more!!");
                return false;
            }
        }
    }
}
// Make a child class of Ninja, for a SpiceHound. A SpiceHound should be "full" at 1200 calories. When a SpiceHound "Consumes":

// If NOT Full
    // adds calorie value to SpiceHound's total calorieIntake (-5 additional calories if the consumable item is "Spicy")
    // adds the randomly selected IConsumable object to SpiceHound's ConsumptionHistory list
    // calls the IConsumable object's GetInfo() method
// If Full
    // issues a warning to the console that the SpiceHound is full and cannot eat anymore