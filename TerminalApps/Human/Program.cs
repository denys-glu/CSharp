using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human John = new Human("John");
            Human Amily = new Human("Amily");
            System.Console.WriteLine("John health before attack: " + John.Health);
            System.Console.WriteLine("John health AFTER attack: " + Amily.Attack(John));
        }

        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
             
            // add a public "getter" property to access health
            public int Health {
                get { return health; }
            }
            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            public Human(string name) {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
            // Add a constructor to assign custom values to all fields
             
            public Human(string name, int str = 3, int intelligence = 3, int dex = 3, int health = 100) {
                Name = name;
                Strength = str;
                Intelligence = intelligence;
                Dexterity = dex;
                this.health = health;
            }
            // Build Attack method
            // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
            public int Attack(Human target)
            {
                target.health =  target.health - (this.Strength * 5);
                return target.Health;
            }
        }

    }
}
