using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class OutputContractLocationRepository : IOutputContractLocationRepository
    {
        private CleanArchitectureDBContext _ctx;

        public OutputContractLocationRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<OutputContractLocation> GetOutputContractLocations()
        {
            return _ctx.outputContractLocations;
        }

        public IEnumerable<OutputContractLocation> GetOutputContractLocation()
        {
            throw new NotImplementedException();
        }
    }
}

