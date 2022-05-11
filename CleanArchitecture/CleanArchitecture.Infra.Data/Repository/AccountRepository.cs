using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using CleanArichitecture.Domain.Interface;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private CleanArchitectureDBContext _ctx; 

        public AccountRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
