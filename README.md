# Exam Alex

## Question01

This is a C# Console Application that displays a menu of items for examination purposes. The user can select an item or exit the application.

### Features

- Displays a list of items with sequential numbers
- Prompts the user for a selection
- Validates user input and displays the selected item or an error message
- Includes an exit option
- Works with arrays of 4, 5, or 6 elements

### How to Run

1. Open a terminal in the project directory.
2. Run the following command:

   ```bash
   dotnet run --project Question01
   ```

### Customization

- To change the menu items, edit the string array in `Program.cs`.

## Question02

This program simulates a simple galaxy exploration game using a C# Console Application. The main features and structure are as follows:

### Features Q2

- Defines a `Galaxy` named "Milky Way".
- Creates two `SolarSystem` objects: "Alpha System" and "Beta System".
- Each solar system contains three `Planet` objects (e.g., "Alpha I", "Alpha II", "Alpha III").
- The galaxy contains both solar systems.
- Displays a menu to the user:
  1. Enter the galaxy (calls `milky_way_galaxy.Enter()`)
  2. Exit the game
- Handles user input to enter the galaxy or exit, with a thank you message on exit.

### How It Works

- The user is prompted to choose between entering the galaxy or exiting the game.
- If the user chooses to enter the galaxy, the program calls the `Enter` method on the `Galaxy` object (implementation not shown here).
- If the user chooses to exit, the program displays a thank you message and terminates.

### Customization Q2

- You can add more solar systems or planets by modifying the initialization code in `Program.cs`.
- The menu and game logic can be extended for more interactive features.

---

This program demonstrates basic object-oriented programming concepts in C#, including classes, objects, and user interaction via the console.
