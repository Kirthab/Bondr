namespace Bondr.Shared.Domain
{
    public class Subscription : BaseDomainModel
    {
        public int? UserId { get; set; }
        public virtual List<User>? Users { get; set; }

    }
}
