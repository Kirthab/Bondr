namespace Bondr.Shared.Domain
{
    public class Community : BaseDomainModel
    {
        public String? Description { get; set; }
        public String? Name { get; set; }
        public int? StaffId { get; set; }
        public virtual List<Staff>? Staff { get; set; }
        public int? SubcriptionId { get; set; }
        public virtual List<Subscription>? Subscriptions { get; set; }
        public int? PostId { get; set; }
        public virtual List<Post>? Posts { get; set; }
        



    }
}
