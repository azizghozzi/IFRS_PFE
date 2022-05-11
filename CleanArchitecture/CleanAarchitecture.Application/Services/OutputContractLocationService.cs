using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class OutputContractLocationService : IOutputContractLocationService
    {
        private IOutputContractLocationRepository _OutputContractLocationRepository;

        public OutputContractLocationService(IOutputContractLocationRepository OutputContractLocationRepository)
        {
            _OutputContractLocationRepository = OutputContractLocationRepository;
        }

        public OutputContractLocationViewModel GetOutputContractLocation()
        {
            return new OutputContractLocationViewModel() {
                OutputContractLocation = _OutputContractLocationRepository.GetOutputContractLocation()
            };


        }

        
    }
}
