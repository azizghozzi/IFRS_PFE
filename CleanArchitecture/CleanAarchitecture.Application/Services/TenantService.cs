using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interface;

namespace CleanAarchitecture.Application.Services
{
    public class TenantService : ITenantService
    {
        private ITenantRepository _TenantRepository;

        public TenantService(ITenantRepository TenantRepository)
        {
            _TenantRepository = TenantRepository;
        }

        public TenantViewModel GetTenant()
        {
            return new TenantViewModel() {
                Tenant = _TenantRepository.GetTenant()
            };


        }

       
    }
}
