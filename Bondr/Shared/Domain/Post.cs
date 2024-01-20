using System.ComponentModel.DataAnnotations;

namespace Bondr.Shared.Domain
{
    public class Post : BaseDomainModel
    {

        [Required]
        public string? Title{ get; set; }
        [Required]
        public string? Content { get; set; }
        public int? Vote { get; set; }
        public int? GenreId { get; set; }
        public virtual List<Genre>? Genre { get; set; }
        public int? UserId { get; set; }
        public virtual List<Visitor>? User { get; set; }
        public int? StaffId { get; set; }
        public virtual List<Staff>? Staffs { get; set;}
        

    }
}
