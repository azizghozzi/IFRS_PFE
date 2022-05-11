using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class TenantRepository : ITenantRepository
    {
        private CleanArchitectureDBContext _ctx;

        public TenantRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Tenant> GetTenants()
        {
            return _ctx.tenants;
        }

        public IEnumerable<Tenant> GetTenant()
        {
            throw new NotImplementedException();
        }
    }
}

