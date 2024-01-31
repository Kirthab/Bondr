using System.ComponentModel.DataAnnotations;

namespace Bondr.Shared.Domain
{
    public class Community : BaseDomainModel
    {
        [Required]
        public String? Description { get; set; }
        [Required]
        public String? Name { get; set; }
        [Required]
        public int? StaffId { get; set; }
        public virtual List<Staff>? Staff { get; set; }
        public int? SubcriptionId { get; set; }
        public virtual List<Subscription>? Subscriptions { get; set; }

    }
}
