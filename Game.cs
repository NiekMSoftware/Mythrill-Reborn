using System.Diagnostics;
using System.Reflection;
using System.Runtime.Remoting;

namespace Mythrill;

public class Game
{
    // Define a player

    public void Start()
    {
        Debug.WriteLine("Starting Game");
        InitializeGame();
        LoadModules();
        MainGameLoop();
    }

    private void InitializeGame()
    {
        Console.WriteLine("Welcome to Mythrill Reborn");
    }

    private void LoadModules()
    {
        Debug.WriteLine("Loading Modules");
        
        // Initialize different modules
        
        Debug.WriteLine("Loaded Modules");
    }

    private void LoadModule(string assemblyName, string typeName)
    {
        ObjectHandle? moduleInstance = Activator.CreateInstance(assemblyName, typeName);
        if (moduleInstance != null)
        {
            // Module unwrapping and loading
        }
    }

    private void MainGameLoop()
    {
        // set up a very basic game loop
        var isPlaying = true;

        Debug.WriteLine("Starting Game Loop");
        
        while (isPlaying)
        {
            Console.Write("\n> ");
            string? command = Console.ReadLine()?.ToLower();

            switch (command)
            {
                case "quit":
                    isPlaying = false;
                    Debug.WriteLine("Quitting Game");
                    Console.WriteLine("Goodbye");
                    break;
                
                // Add several more commands
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}