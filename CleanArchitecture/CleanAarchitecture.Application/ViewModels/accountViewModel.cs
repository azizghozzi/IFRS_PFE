using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanAarchitecture.Application.ViewModels
{
    public class accountViewModel
    {
        internal object Account;

        public IEnumerable<Account> accounts { get; set; }
    }
}
