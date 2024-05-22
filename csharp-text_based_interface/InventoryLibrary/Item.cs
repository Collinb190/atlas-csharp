using System;

namespace InventoryLibrary
{
    /// <summary> 
    /// This class inherits from BaseClass and creats an Item.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// This propety is responsible for the name of the item.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// This constructor requires a name to instantiate the class.
        /// </summary>
        /// <param name="name"> The name of the item. </param>
        /// <exception cref="ArgumentException"> Item must have a value. </exception>
        public Item(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            this.name = name;
        }
    }
}
