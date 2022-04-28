using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string login { get; set; }
          
        public string Password { get; set; }
    }
}
