using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class EcheanceContractLocationRepository : IEcheanceContractLocationRepository
    {
        private CleanArchitectureDBContext _ctx;

        public EcheanceContractLocationRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<EcheanceContractLocation> GetEcheanceContractLocations()
        {
            return _ctx.echanceContratLocation;
        }
    }
 
    }

