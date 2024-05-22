using System;

namespace InventoryLibrary
{
    /// <summary> 
    /// This class inherits from BaseClass and creats an User.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// This propety is responsible for the name of the User.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// This constructor requires a name to instantiate the class.
        /// </summary>
        /// <param name="name"> The name of the User. </param>
        /// <exception cref="ArgumentException"> User must have a value. </exception>
        public User(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            this.name = name;
        }
    }
}
