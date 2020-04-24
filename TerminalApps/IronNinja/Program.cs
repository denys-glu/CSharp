using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsumable rice = new Food("Rice", 300, true, false);
            IConsumable banana = new Food("Banana", 300, false, true);
            IConsumable cholotaCake = new Food("Chocolate Cake", 700, false, true);
            IConsumable borcsh = new Food("Borcsh", 600, false, false);
            IConsumable lasagna = new Food("Lasagna", 600, false, false);
            IConsumable ramen = new Food("Ramen", 400, true, false);
            IConsumable burger = new Food("Burger", 800, false, false);
            IConsumable milkShake = new Drink("Milk Shake", 700, false);
            IConsumable coke = new Drink("Coke", 300, false);
            IConsumable pepsi = new Drink("Pepsi", 300, false);
            IConsumable tea = new Drink("London Fog", 700, false);
            Buffet SongsBuffet = new Buffet();
            SongsBuffet.AddToMenu(rice);
            SongsBuffet.AddToMenu(cholotaCake);
            SongsBuffet.AddToMenu(ramen);
            SongsBuffet.AddToMenu(tea);
            SongsBuffet.AddToMenu(milkShake);

            Ninja sweetEater = new SweetTooth();
            Ninja spiceHunter = new SpiceHound();
            System.Console.WriteLine("Sweet");
            sweetEater.Consume(SongsBuffet.Serve());
            sweetEater.Consume(SongsBuffet.Serve());
            sweetEater.Consume(SongsBuffet.Serve());
            sweetEater.Consume(SongsBuffet.Serve());
            sweetEater.Consume(SongsBuffet.Serve());
            System.Console.WriteLine("            ");
            System.Console.WriteLine("Spicy");
            spiceHunter.Consume(SongsBuffet.Serve());
            spiceHunter.Consume(SongsBuffet.Serve());
            spiceHunter.Consume(SongsBuffet.Serve());
            spiceHunter.Consume(SongsBuffet.Serve());

            System.Console.WriteLine("=====================");
            System.Console.WriteLine(spiceHunter.ConsumptionHistory.Count);
            System.Console.WriteLine(sweetEater.ConsumptionHistory.Count);
            if (spiceHunter.ConsumptionHistory.Count > sweetEater.ConsumptionHistory.Count)
            {
                System.Console.WriteLine($"SpiceHunter is the winner with {spiceHunter.ConsumptionHistory.Count} of dishes eaten");

            }
            else if (spiceHunter.ConsumptionHistory.Count == sweetEater.ConsumptionHistory.Count)
            {
                System.Console.WriteLine($"Looks like there is a tie with {spiceHunter.ConsumptionHistory.Count} == {sweetEater.ConsumptionHistory.Count}");
            }
            else
            {
                System.Console.WriteLine($"SweetEater is the winner with {sweetEater.ConsumptionHistory.Count} of dishes eaten");
            }
        }
    }
}
