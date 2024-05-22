using System;

namespace InventoryLibrary
{
    /// <summary> 
    /// This class inherits from BaseClass and creats an Inventory.
    /// </summary>
    public class Inventory : BaseClass
    {
        public string user_id { get; }
        public string item_id { get; }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Quantity cannot be less than 0.", nameof(value));
                quantity = value;
            }
        }
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            if (string.IsNullOrEmpty(user_id))
                throw new ArgumentException("User ID cannot be null or empty", nameof(user_id));
            else if (string.IsNullOrEmpty(item_id))
                throw new ArgumentException("Item ID cannot be null or empty", nameof(item_id));
            this.user_id = user_id;
            this.item_id = item_id;
            this.Quantity = quantity;
        }
    }
}
