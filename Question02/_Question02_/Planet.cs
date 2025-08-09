using System;

public class Planet : Location
{
    public Planet(string name) : base(name) { }

    public override void Enter()
    {
        while (true)
        {
            Console.WriteLine($"Choose an action for the Planet \"{GetName()}\":");
            Console.WriteLine("1. Buy goods");
            Console.WriteLine("2. Sell goods");
            Console.WriteLine("3. Leave the planet");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Goods bought!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Goods sold!");
            }
            else if (choice == "3")
            {
                break;
            }
        }
    }
}
