using System.ComponentModel.DataAnnotations;

namespace Bondr.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Gender { get; set; }
        [Required]
        public string? Position { get; set; }
        [Required]
        public double? Salary { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
    }

