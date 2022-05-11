using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class RenewalOptionRepository : IRenewalOptionRepository
    {
        private CleanArchitectureDBContext _ctx;

        public RenewalOptionRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<RenewalOption> GetRenewalOptions()
        {
            return _ctx.renewalOptions;
        }

        public IEnumerable<RenewalOption> GetRenewalOption()
        {
            throw new NotImplementedException();
        }
    }
}

