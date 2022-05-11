using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class EcheanceContractLocationHistoryService : IEcheanceContractLocationHistoryService
    {
        private IEcheanceContractLocationHistoryRepository _EcheanceContractLocationHistoryRepository;

        public EcheanceContractLocationHistoryService(IEcheanceContractLocationHistoryRepository EcheanceContractLocationHistoryRepository)
        {
            _EcheanceContractLocationHistoryRepository = EcheanceContractLocationHistoryRepository;
        }

        public EcheanceContractLocationHistoryViewModel GetEcheanceContractLocationHistory()
        {
            return new EcheanceContractLocationHistoryViewModel() {
                EcheanceContractLocationHistory = _EcheanceContractLocationHistoryRepository.GetEcheanceContractLocationHistory()
            };


        }

    }

   
}
