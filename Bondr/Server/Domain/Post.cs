using Bondr.Server.Models;
using System.Xml.Linq;

namespace Bondr.Server.Domain
{
    public class Post : BaseDomainModel
    {

        public string Title{ get; set; }
        public string? Content { get; set; }
        public int Vote { get; set; }
        public int GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public int CommentID { get; set; }
        public virtual Comment? Comment { get; set; }
        public virtual List<Comment>? Comments { get; set; }

    }
}
