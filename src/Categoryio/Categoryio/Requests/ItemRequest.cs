namespace Categoryio.Api.Requests
{
    public class ItemRequest
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Image URI.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Id of the Category.
        /// </summary>
        public int CategoryId { get; set; }
    }
}
