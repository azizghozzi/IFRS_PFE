using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class EcheanceContractLocationHistoryRepository : IEcheanceContractLocationHistoryRepository
    {
        private CleanArchitectureDBContext _ctx;

        public EcheanceContractLocationHistoryRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<EcheanceContractLocationHistory> GetEcheanceContractLocationHistories()
        {
            return _ctx.echanceContratLocationHistories;
        }

        public IEnumerable<EcheanceContractLocationHistory> GetEcheanceContractLocationHistory()
        {
            throw new NotImplementedException();
        }
    }
}

