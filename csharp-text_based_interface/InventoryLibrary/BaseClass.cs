using System;

namespace InventoryLibrary
{
    /// <summary> Class that all others will inherit from. </summary>
    public class BaseClass
    {
        /// <summary> Unique id for the object. </summary>
        public string id { get; set; }
        /// <summary> Time the object was created </summary>
        public DateTime date_created { get; set; }
        /// <summary> Time the object was updated </summary>
        public DateTime date_updated { get; set; }

        /// <summary> Constructs a new instance of BaseClass. </summary>
        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.Now;
            date_updated = DateTime.Now;
        }
    }
}
