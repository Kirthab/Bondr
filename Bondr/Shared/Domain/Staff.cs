namespace Bondr.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Position { get; set; }
        public double? Salary { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        }
    }

