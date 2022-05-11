using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class RenewalOptionService : IRenewalOptionService
    {
        private IRenewalOptionRepository _RenewalOptionRepository;

        public RenewalOptionService(IRenewalOptionRepository RenewalOptionRepository)
        {
            _RenewalOptionRepository = RenewalOptionRepository;
        }

        public RenewalOptionViewModel GetRenewalOption()
        {
            return new RenewalOptionViewModel() {
                RenewalOption = _RenewalOptionRepository.GetRenewalOption()
            };


        }

        
    }
}
