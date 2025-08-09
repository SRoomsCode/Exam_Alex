using System;

public class Location
{
    private string _name;
    private Location[] _locationTable;
    private int _locationCount;

    public Location(string name)
    {
        _name = name;
        _locationTable = new Location[5];
        _locationCount = 0;
    }

    public string GetName()
    {
        return _name;
    }

    public void AddLocation(Location location_to_add)
    {
        if (_locationCount >= _locationTable.Length)
        {
            Console.WriteLine("Location table is full!");
            return;
        }
        _locationTable[_locationCount] = location_to_add;
        _locationCount++;
    }

    public int GetLocationCount()
    {
        return _locationCount;
    }

    public virtual void Enter()
    {
        Console.WriteLine($"You have entered the Location: {_name}");
        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. List contained locations");
            Console.WriteLine("2. Leave this location");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                if (_locationCount == 0)
                {
                    Console.WriteLine("No contained locations.");
                    continue;
                }
                for (int i = 0; i < _locationCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {_locationTable[i].GetName()}");
                }
                Console.WriteLine("Select a location number to enter, or 0 to cancel:");
                if (int.TryParse(Console.ReadLine(), out int sel) && sel > 0 && sel <= _locationCount)
                {
                    _locationTable[sel - 1].Enter();
                }
            }
            else if (choice == "2")
            {
                break;
            }
        }
    }
}
