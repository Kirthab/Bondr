using System.ComponentModel.DataAnnotations;

namespace Bondr.Shared.Domain
{
    public class Genre : BaseDomainModel
    {
        [Required]
        public String? Name { get; set; }
        [Required]
        public String? Description {  get; set; }

    }
}
