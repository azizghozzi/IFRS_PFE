using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class TenantViewModel
    {
        internal object Tenant;

        public IEnumerable<Tenant> tenants { get; set; }
    }
}
