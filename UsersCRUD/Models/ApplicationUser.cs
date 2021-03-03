using Microsoft.AspNetCore.Identity;

namespace UsersCRUD.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Cin { get; set; }

    }
}