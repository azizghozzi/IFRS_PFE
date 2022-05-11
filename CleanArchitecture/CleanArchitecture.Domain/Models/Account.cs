using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string login { get; set; }
          
        public string Password { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
