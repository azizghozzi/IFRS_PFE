using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class RenewalOption
    {
        public int RenewalOptionId { get; set ;}
        public string description { get; set; }
        public int value { get; set; }

        public virtual ContractLocation ContractLocation { get; set; }
        public virtual ContractLocationHistory ContractLocationHistory { get; set; }
    }
}
