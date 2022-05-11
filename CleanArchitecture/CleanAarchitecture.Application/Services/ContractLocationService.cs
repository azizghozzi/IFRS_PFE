using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class ContractLocationService : IContractLocationService
    {
        private IContractLocationRepository _ContractLocationRepository;

        public ContractLocationService(IContractLocationRepository ContractLocationRepository)
        {
            _ContractLocationRepository = ContractLocationRepository;
        }

        public ContractLocationViewModel GetContractLocation()
        {
            return new ContractLocationViewModel() {
                ContractLocation = _ContractLocationRepository.GetContractLocation()
            };


        }

        public IEnumerable<IContractLocationRepository> GetContractLocationRepository()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IContractLocationRepository> GetLocationRepositories()
        {
            throw new NotImplementedException();
        }

     
    }
}
