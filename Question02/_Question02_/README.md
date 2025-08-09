# Question02

This program simulates a simple galaxy exploration game using a C# Console Application. The main features and structure are as follows:

## Features

- Defines a `Galaxy` named "Milky Way".
- Creates two `SolarSystem` objects: "Alpha System" and "Beta System".
- Each solar system contains three `Planet` objects (e.g., "Alpha I", "Alpha II", "Alpha III").
- The galaxy contains both solar systems.
- Displays a menu to the user:
  1. Enter the galaxy (calls `milky_way_galaxy.Enter()`)
  2. Exit the game
- Handles user input to enter the galaxy or exit, with a thank you message on exit.

## How It Works

- The user is prompted to choose between entering the galaxy or exiting the game.
- If the user chooses to enter the galaxy, the program calls the `Enter` method on the `Galaxy` object (implementation not shown here).
- If the user chooses to exit, the program displays a thank you message and terminates.

## Customization

- You can add more solar systems or planets by modifying the initialization code in `Program.cs`.
- The menu and game logic can be extended for more interactive features.

---

This program demonstrates basic object-oriented programming concepts in C#, including classes, objects, and user interaction via the console.
