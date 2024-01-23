namespace Bondr.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {
        public int? UserId { get; set; }
        public virtual List<Visitor>? Users { get; set; }

    }
}
