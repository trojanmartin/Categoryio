namespace Categoryio.Api.Requests
{
    public class RoomRequest
    {
        /// <summary>
        /// Id of the room.
        /// </summary>
        public int Id { get; set; }

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
    }
}
