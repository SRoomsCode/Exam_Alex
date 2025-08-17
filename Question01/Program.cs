
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] items = { "Wafflia", "Saxophonia", "Scaldis", "Mosa", "Carbonara" };
        while (true)
        {
            Console.WriteLine("Welcome to your examination");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
            Console.WriteLine($"{items.Length + 1}. Exit");
            Console.Write("Please make a selection: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Input was null. Please enter a value.");
                continue;
            }
            int choice;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            if (choice == items.Length + 1)
            {
                Console.WriteLine("Thank you for using the program. Goodbye!");
                break;
            }
            if (choice >= 1 && choice <= items.Length)
            {
                Console.WriteLine($"You selected: {items[choice - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
            Console.WriteLine();
        }
    }
}
