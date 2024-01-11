using Bondr.Server.Domain;
using Microsoft.AspNetCore.Identity;

namespace Bondr.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string? Avatar { get; set; }
        public string? Status { get; set; }

        public virtual List<Subscription>? Subscriptions { get; set; }
        public virtual List<Post>? Posts { get; set; }
        public virtual List<Comment>? Comments { get; set; }

    }
}