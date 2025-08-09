using System;

public class SolarSystem : Location
{
    public SolarSystem(string name) : base(name) { }

    public override void Enter()
    {
        while (true)
        {
            Console.WriteLine($"Choose an action for the Solar System \"{GetName()}\":");
            Console.WriteLine("1. Charge batteries");
            Console.WriteLine("2. List available planets");
            Console.WriteLine("3. Leave the solar system");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Batteries charged.");
            }
            else if (choice == "2")
            {
                int count = GetLocationCount();
                if (count == 0)
                {
                    Console.WriteLine("No planets available.");
                    continue;
                }
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{i + 1}. {GetLocationAt(i).GetName()}");
                }
                Console.WriteLine("Select a planet number to enter, or 0 to cancel:");
                if (int.TryParse(Console.ReadLine(), out int sel) && sel > 0 && sel <= count)
                {
                    GetLocationAt(sel - 1).Enter();
                }
            }
            else if (choice == "3")
            {
                break;
            }
        }
    }

    // Helper to access contained locations
    private Location GetLocationAt(int index)
    {
        // Use reflection to access private _locationTable if needed, but here we assume direct access
        // If not accessible, move _locationTable to protected in Location
        var type = typeof(Location);
        var field = type.GetField("_locationTable", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        Location[] table = (Location[])field.GetValue(this);
        return table[index];
    }
}
