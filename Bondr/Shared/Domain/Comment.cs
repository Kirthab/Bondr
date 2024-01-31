using System.ComponentModel.DataAnnotations;

namespace Bondr.Shared.Domain
{
    public class Comment : BaseDomainModel
    {
        [Required]
        public string? Text { get; set; }
        public int? Vote { get; set; }
        public int? UserId{ get; set; }
        public int? PostId{ get; set; }
        public virtual List<Visitor>? Users { get; set; }
        public int? StaffId { get; set; }
        public virtual List<Staff>? Staffs { get; set; }
    }
}
