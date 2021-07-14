using System;

namespace Categoryio.Api.Database.Models
{
    /// <summary>
    /// Represents room.
    /// </summary>
    public class Room : BaseEntity
    {
        /// <summary>
        /// Name of the room.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Floor number.
        /// </summary>
        public int Floor { get; set; } 

        /// <summary>
        /// Door number. 
        /// </summary>
        public string DoorNumber { get; set; }

        /// <summary>
        /// Description of the room.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// When room was created.
        /// </summary>
        public DateTime Created { get; set; }
    }
}
