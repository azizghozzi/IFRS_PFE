using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class ContractLocationRepository : IContractLocationRepository
    {

        private CleanArchitectureDBContext _ctx;

        public ContractLocationRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<ContractLocation> GetContractLocations()
        {
            return _ctx.ContractLocations;
        }

        public object GetContractLocation()
        {
            throw new NotImplementedException();
        }

       
    }
}

