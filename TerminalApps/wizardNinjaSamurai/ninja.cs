using System;

namespace wizardNinjaSamurai
{
    public class Ninja: Human {

        Random rand = new Random();
        public Ninja(string name): base(name){
            Dexterity = 175;
            health = 100;
        }

        public override int Attack(Human target)
        {
            
            int dmg = 5 * Dexterity;
            if(rand.Next(1,101) <= 20) {
                dmg += 10;
            }
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            health += 5;
            System.Console.WriteLine($"{target.Name} 5 health was stolen, {Name} health was recoverd by 5 and now is {Health}");
        }
    }
}
// Ninja should have a default dexterity of 175
// Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
// Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.