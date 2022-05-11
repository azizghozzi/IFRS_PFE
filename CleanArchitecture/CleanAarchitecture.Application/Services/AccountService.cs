using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArichitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public accountViewModel Getaccounts()
        {
            return new accountViewModel() {
                Account = _accountRepository.GetAccounts()
            };


        }
    }
}
