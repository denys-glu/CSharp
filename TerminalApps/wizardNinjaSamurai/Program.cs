using System;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human dummy = new Human("Dummy");
            Wizard gandalf = new Wizard("Gandalf");
            Ninja asta = new Ninja("Asta");
            Samurai jack = new Samurai("Jack");

            jack.Attack(asta);
            jack.Attack(asta);
            jack.Attack(asta);
            jack.Attack(asta);
            jack.Attack(asta);
            jack.Attack(asta);
            jack.Attack(asta);
            asta.Steal(jack);

            // System.Console.WriteLine($"Gandalf's health is {gandalf.Health} and Intelligence is {gandalf.Intelligence}");

            // System.Console.WriteLine($"Dummy's health is {dummy.Health} and Intelligence is {dummy.Intelligence}");

            // dummy.Attack(gandalf);
            // System.Console.WriteLine($"Gandalf's health after attack is {gandalf.Health}");
            // gandalf.Attack(dummy);
            // System.Console.WriteLine($"Gandalf's health after striking back is {gandalf.Health} and Dummy's health is {dummy.Health}");
            // gandalf.Heal(dummy);
            // System.Console.WriteLine($"Gandalf heals dummy and Dummy's health is {dummy.Health}");
        }
    }
}
