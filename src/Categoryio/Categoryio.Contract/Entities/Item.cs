using System;
using System.Collections.Generic;

namespace Categoryio.Common.Entities
{
    /// <summary>
    /// Defines item.
    /// </summary>
    public class Item : BaseEntity
    {
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
        /// When item was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Category of the item.
        /// </summary>
        public ICollection<Category> Categories { get; set; }
    }
}
