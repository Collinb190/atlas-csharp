using System;

namespace InventoryLibrary
{
    /// <summary> Class that all others will inherit from. </summary>
    public class BaseClass
    {
        /// <summary> Unique id for the object that does not change. </summary>
        public string id { get; }

        /// <summary> Time the object was created that does not change. </summary>
        public DateTime date_created { get; }

        /// <summary> Time the object was updated and can change. </summary>
        public DateTime date_updated { get; private set; }

        /// <summary> Constructs a new instance of BaseClass. </summary>
        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.Now;
            date_updated = date_created;
        }

        /// <summary> Setter method to change date_updated. </summary>
        public void UpdateDate()
        {
            date_updated = DateTime.Now;
        }
    }
}
