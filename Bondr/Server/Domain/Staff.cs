namespace Bondr.Server.Domain
{
    public class Staff : BaseDomainModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public int? PostId { get; set; }
        public virtual Post? Post { get; set; }

        public int? CommentId { get; set; }
        public virtual Comment? Comment { get; set; }

        public virtual List<Community>? Communities { get; set; }
        public virtual List<Post>? Posts { get; set; }
        public virtual List<Comment>? Comments { get; set; }
    }
}
