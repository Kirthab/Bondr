namespace Bondr.Server.Domain
{
    public class Community : BaseDomainModel
    {
        public String? Description { get; set; }
        public String Name { get; set; }
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
        public int SubscriptionId { get; set; }
        public virtual Subscription? Subscription { get; set; }
        public int PostId { get; set; }
        public virtual Post? Post{ get; set; }

        public virtual List<Subscription>? Subscriptions { get; set; }
        public virtual List<Post>? Posts { get; set; }

    }
}
