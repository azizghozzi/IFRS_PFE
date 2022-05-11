using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
