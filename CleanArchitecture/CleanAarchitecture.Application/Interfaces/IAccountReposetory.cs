using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Domain.Interface
{
    public interface IAccountReposetory
    {
        IEnumerable<Account> GetAccounts();

    }
}
