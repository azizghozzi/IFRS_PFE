using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class ContractLocationHistoryService : IContractLocationHistoryService
    {
        private IContractLocationHistoryRepository _ContractLocationHistoryRepository;

        public ContractLocationHistoryService(IContractLocationHistoryRepository ContractLocationHistoryRepository)
        {
            _ContractLocationHistoryRepository = ContractLocationHistoryRepository;
        }

        public contractLocationHistoryViewModel GetContractLocationHistory()
        {
            return new contractLocationHistoryViewModel() {
                contractLocationHistory = _ContractLocationHistoryRepository.GetContractLocationHistory()
            };


        }

        contractLocationHistoryViewModel Interfaces.IContractLocationHistoryService.GetContractLocationHistory()
        {
            throw new NotImplementedException();
        }

        internal interface IContractLocationHistoryService
        {
        }
    }
}
