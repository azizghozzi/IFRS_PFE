using System;
using CleanArichitecture.Domain.Models;
using System.Collections.Generic;
using System.Text;

namespace CleanArichitecture.Domain.Interface
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}