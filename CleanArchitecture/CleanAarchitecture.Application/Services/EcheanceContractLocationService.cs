using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class EcheanceContractLocationService : IEcheanceContractLocationService
    {
        private IEcheanceContractLocationRepository _EcheanceContractLocationRepository;

        public EcheanceContractLocationService(IEcheanceContractLocationRepository EcheanceContractLocationRepository)
        {
            _EcheanceContractLocationRepository = EcheanceContractLocationRepository;
        }

        public EcheanceContractLocationViewModel GetEcheanceContractLocation()
        {
            return new EcheanceContractLocationViewModel() {
                EcheanceContractLocation = _EcheanceContractLocationRepository.getEcheanceContractLocation()
            };


        }

    }
}
