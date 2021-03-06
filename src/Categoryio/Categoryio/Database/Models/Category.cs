using System;
using System.Collections.Generic;

namespace Categoryio.Api.Database.Models
{
    /// <summary>
    /// Definition of the category.
    /// </summary>
    public class Category : BaseEntity
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// When category was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Category items.
        /// </summary>
        public ICollection<Item> Items { get; set; }
    }
}
