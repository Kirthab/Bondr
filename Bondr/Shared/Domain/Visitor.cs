using Bondr.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bondr.Shared.Domain
{
    public class Visitor : BaseDomainModel
    {
        public string? Username { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? Avatar { get; set; }
        public string? CardImg { get; set; }
        public string? Status { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? SubscriptionId { get; set; }
        public virtual List<Subscription>? Subscriptions { get; set; }
    }
}
