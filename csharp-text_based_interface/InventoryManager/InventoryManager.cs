using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Test creating an Inventory with valid parameters
            try
            {
                Inventory validInventory = new Inventory("user123", "item456", 5);
                Console.WriteLine("Created an Inventory with valid parameters:");
                Console.WriteLine($"ID: {validInventory.id}");
                Console.WriteLine($"User ID: {validInventory.user_id}");
                Console.WriteLine($"Item ID: {validInventory.item_id}");
                Console.WriteLine($"Quantity: {validInventory.Quantity}");
                validInventory.Quantity = 10;
                Console.WriteLine($"Quantity: {validInventory.Quantity}");
                Console.WriteLine($"Date Created: {validInventory.date_created}");
                Console.WriteLine($"Date Updated: {validInventory.date_updated}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine();

            // Test creating an Inventory with an invalid (empty) user ID
            try
            {
                Inventory invalidInventory = new Inventory("", "item789", 3); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught while creating an Inventory with an empty user ID:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            // Test creating an Inventory with an invalid (empty) item ID
            try
            {
                Inventory invalidInventory = new Inventory("user123", "", 3); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught while creating an Inventory with an empty item ID:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            // Test creating an Inventory with a negative quantity
            try
            {
                Inventory invalidInventory = new Inventory("user123", "item789", -1); // This should throw an exception
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception caught while creating an Inventory with a negative quantity:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
