using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArichitecture.Domain.Interface
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}