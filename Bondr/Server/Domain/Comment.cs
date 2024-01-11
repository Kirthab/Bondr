using Bondr.Server.Models;

namespace Bondr.Server.Domain
{
    public class Comment : BaseDomainModel
    {
        public string Text { get; set; }
        public int Vote { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
