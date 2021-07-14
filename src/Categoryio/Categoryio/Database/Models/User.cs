namespace Categoryio.Api.Database.Models
{
    public class User : BaseEntity
    {
        /// <summary>
        /// First name of the user.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Last name of the user.
        /// </summary>
        public string LastName { get; set; }
    }
}
