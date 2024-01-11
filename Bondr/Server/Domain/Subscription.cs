using Bondr.Server.Models;

namespace Bondr.Server.Domain
{
    public class Subscription : BaseDomainModel
    {
        public int UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

    }
}
