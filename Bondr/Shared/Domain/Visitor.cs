using Bondr.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bondr.Shared.Domain
{
    public class Visitor : BaseDomainModel
    {
        [Required]
        public string? Username { get; set; }
        public string? Gender { get; set; }
        public string? Role { get; set; }
        public int? Age { get; set; }
        public string? Avatar { get; set; }
        public string? CardImg { get; set; }
        public string? Status { get; set; } 
        public string? Email { get; set; } // Linked to net user
        public string? Password { get; set; } // Linked to net user
        public int? SubscriptionId { get; set; }
        
        public virtual List<Subscription>? Subscriptions { get; set; }
    }
}
