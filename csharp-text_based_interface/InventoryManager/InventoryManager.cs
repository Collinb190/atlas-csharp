using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {        static void Main(string[] args)
        {
            // Test creating an Item with a valid name
            try
            {
                Item validItem = new Item("Valid Item");
                Console.WriteLine("Created an item with a valid name:");
                Console.WriteLine($"ID: {validItem.id}");
                Console.WriteLine($"Name: {validItem.name}");
                Console.WriteLine($"Date Created: {validItem.date_created}");
                Console.WriteLine($"Date Updated: {validItem.date_updated}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine();

            // Test creating an Item with an invalid (empty) name
            try
            {
                Item invalidItem = new Item(""); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught while creating an item with an empty name:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            // Test creating an Item with a null name
            try
            {
                Item nullNameItem = new Item(null); // This should throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught while creating an item with a null name:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
