using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of BaseClass
            BaseClass item1 = new BaseClass();

            // Display initial values
            Console.WriteLine("Initial values:");
            Console.WriteLine($"ID: {item1.id}");
            Console.WriteLine($"Date Created: {item1.date_created}");
            Console.WriteLine($"Date Updated: {item1.date_updated}");

            // Wait for a few seconds to show the difference in time
            System.Threading.Thread.Sleep(2000); // 2-second delay

            // Update the date_updated property using the method
            item1.UpdateDate();

            // Display updated values
            Console.WriteLine("\nUpdated values:");
            Console.WriteLine($"ID: {item1.id}");
            Console.WriteLine($"Date Created: {item1.date_created}");
            Console.WriteLine($"Date Updated: {item1.date_updated}");
        }
    }
}
