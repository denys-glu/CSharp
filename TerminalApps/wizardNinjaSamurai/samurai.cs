using System;

namespace wizardNinjaSamurai
{
    public class Samurai: Human {

        Random rand = new Random();
        public Samurai(string name): base(name){
            health = 200;
        }

        public override int Attack(Human target)
        {
            
            int dmg = Strength * 3;
            if (target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{target.Name} had less than 50 HP {Name} did a critical blow and killed him!");
                return target.Health;
            }
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! {target.Name}'s health is {target.Health} ");
            return target.Health;
        }

        public void Meditate()
        {
            health = 200;
            System.Console.WriteLine($"{Name} has recoverd his health to full");
        }
    }
}

// Samurai should have a default health of 200
// Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
// Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health