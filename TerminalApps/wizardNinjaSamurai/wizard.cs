using System;

namespace wizardNinjaSamurai
{
    public class Wizard: Human {
        public Wizard(string name): base(name){
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = 3 * Intelligence;
            target.Health -= dmg;
            health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public void Heal(Human target)
        {
            target.Health += 10 * Intelligence;
            System.Console.WriteLine($"{target.Name} was heald {10 * Intelligence} HP");
        }
    }
}

// Wizard should have a default health of 50 and Intelligence of 25
// Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
// Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence