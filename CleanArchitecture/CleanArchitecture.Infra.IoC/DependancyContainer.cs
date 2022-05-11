

using CleanAarchitecture.Application.Interfaces;
using CleanAarchitecture.Application.Services;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Infra.Data.Repository;
using CleanArichitecture.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //application Layer
            services.AddScoped<IContractLocationService, ContractLocationService>();
                
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IContractLocationHistoryService, ContractLocationHistoryService>();

            services.AddScoped<IEcheanceContractLocationHistoryService, EcheanceContractLocationHistoryService>();

            services.AddScoped<IEcheanceContractLocationService, EcheanceContractLocationService>();

            services.AddScoped<IOutputContractLocationService, OutputContractLocationService>();
            
            services.AddScoped<IRenewalOptionService, RenewalOptionService>();

            services.AddScoped<ITenantService, TenantService>();
            //Infra.Data Layer 
            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddScoped<IContractLocationHistoryRepository, ContractLocationHistoryRepository>();

            services.AddScoped<IContractLocationRepository, ContractLocationRepository>();

            services.AddScoped<IEcheanceContractLocationHistoryRepository, EcheanceContractLocationHistoryRepository>();

            services.AddScoped<IEcheanceContractLocationRepository, EcheanceContractLocationRepository>();
            
            services.AddScoped<IOutputContractLocationRepository, OutputContractLocationRepository>();

            services.AddScoped<IRenewalOptionRepository, RenewalOptionRepository>();

            services.AddScoped<ITenantRepository, TenantRepository>();
        }
    }
}
