namespace Bondr.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {
        public int? UserId { get; set; }
        public virtual Visitor? Users { get; set; }
        public int? CommunityId { get; set; }
        public virtual Community? Community { get; set; }

    }
}
