using System;

class Program
{
    static void Main(string[] args)
    {
        Galaxy milky_way_galaxy = new Galaxy("Milky Way");

        SolarSystem alphaSystem = new SolarSystem("Alpha System");
        alphaSystem.AddLocation(new Planet("Alpha I"));
        alphaSystem.AddLocation(new Planet("Alpha II"));
        alphaSystem.AddLocation(new Planet("Alpha III"));

        SolarSystem betaSystem = new SolarSystem("Beta System");
        betaSystem.AddLocation(new Planet("Beta I"));
        betaSystem.AddLocation(new Planet("Beta II"));
        betaSystem.AddLocation(new Planet("Beta III"));

        milky_way_galaxy.AddLocation(alphaSystem);
        milky_way_galaxy.AddLocation(betaSystem);

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine($"1. Enter galaxy {milky_way_galaxy.GetName()}");
            Console.WriteLine("2. Exit the game");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                milky_way_galaxy.Enter();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }
        }
    }
}
