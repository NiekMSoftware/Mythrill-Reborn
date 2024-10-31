using System.Diagnostics;
using Mythrill.Shared;

namespace Mythrill.Inventory
{
    public class InventoryModule : IGameModule
    {
        private List<Item>? _items;
        
        public void LoadModule()
        {
            _items = new List<Item>();
            Console.WriteLine("Inventory module loaded.");
        }

        public void AddItem(Item item)
        {
            _items?.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _items?.Remove(item);
        }

        public void ListItems()
        {
            Console.WriteLine("Inventory:");
            if (_items == null)
            {
                Debug.WriteLine("No items have been added.");
                return;
            }
            
            foreach (Item item in _items)
            {
                Console.WriteLine($" - {item.Name}: {item.Description}");
            }
        }
    }
}