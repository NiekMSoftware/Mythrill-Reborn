using System.Diagnostics;
using System.Runtime.Remoting;
using Mythrill.Shared;

namespace Mythrill
{
    public class Game
    {
        // Define a player
        private Player? _player;
        
        public void Start()
        {
            Debug.WriteLine("Starting Game");
            InitializeGame();
            LoadModules();
            MainGameLoop();
        }
    
        private void InitializeGame()
        {
            _player = new Player("Hero");   
            Console.WriteLine("Welcome to Mythrill Reborn");
        }
    
        private void LoadModules()
        {
            Debug.WriteLine("Loading Modules");
            
            // Initialize different modules
            LoadModule("Mythrill.Inventory", "Mythrill.Inventory.InventoryModule");
            
            Debug.WriteLine("Loaded Modules");
        }
    
        private void LoadModule(string assemblyName, string typeName)
        {
            ObjectHandle? moduleInstance = Activator.CreateInstance(assemblyName, typeName);
            if (moduleInstance == null) return;
            
            // Module unwrapping and loading
            var module = moduleInstance.Unwrap() as IGameModule;
            module?.LoadModule();
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
}