namespace Bondr.Server.Domain
{
    public class Genre : BaseDomainModel
    {
        public String Name { get; set; }
        public String Description {  get; set; }
        public virtual List<Post>? Posts { get; set; }

    }
}
