using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class RenewalOptionViewModel
    {
        internal object RenewalOption;

        public IEnumerable<RenewalOption> renewalOptions { get; set; }
    }
}
