using System;
using System.Collections.Generic;
using InventoryLibrary;
using System.IO;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of JSONStorage
            JSONStorage storage = new JSONStorage();

            // Test adding a User to the storage
            try
            {
                User user = new User("Test User");
                storage.New(user);
                Console.WriteLine("Added User to storage:");
                Console.WriteLine($"ID: {user.id}");
                Console.WriteLine($"Name: {user.name}");
                Console.WriteLine($"Date Created: {user.date_created}");
                Console.WriteLine($"Date Updated: {user.date_updated}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine();

            // Test adding an Item to the storage
            try
            {
                Item item = new Item("Test Item");
                storage.New(item);
                Console.WriteLine("Added Item to storage:");
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Name: {item.name}");
                Console.WriteLine($"Date Created: {item.date_created}");
                Console.WriteLine($"Date Updated: {item.date_updated}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine();

            // Test adding an Inventory to the storage
            try
            {
                Inventory inventory = new Inventory("User1", "Item1", 5);
                storage.New(inventory);
                Console.WriteLine("Added Inventory to storage:");
                Console.WriteLine($"User ID: {inventory.user_id}");
                Console.WriteLine($"Item ID: {inventory.item_id}");
                Console.WriteLine($"Quantity: {inventory.Quantity}");
                Console.WriteLine($"Date Created: {inventory.date_created}");
                Console.WriteLine($"Date Updated: {inventory.date_updated}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine();

            // Test saving to JSON file
            try
            {
                storage.Save();
                Console.WriteLine("Data saved to JSON file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during save: {ex.Message}");
            }

            Console.WriteLine();

            // Test loading from JSON file
            try
            {
                JSONStorage newStorage = new JSONStorage();
                newStorage.Load();
                Console.WriteLine("Data loaded from JSON file:");

                foreach (var obj in newStorage.All())
                {
                    Console.WriteLine($"Key: {obj.Key}, Object: {obj.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception during load: {ex.Message}");
            }
        }
    }
}
