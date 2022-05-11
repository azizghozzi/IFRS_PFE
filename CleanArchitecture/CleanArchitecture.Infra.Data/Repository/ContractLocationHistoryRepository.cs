using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Interface;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class ContractLocationHistoryRepository : IContractLocationHistoryRepository
    {
        private CleanArchitectureDBContext _ctx;

        public ContractLocationHistoryRepository(CleanArchitectureDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<ContractLocationHistory> GetContractLocationHistories()
        {
            return _ctx.ContractLocationHistories;
        }

        public IEnumerable<ContractLocationHistory> GetContractLocationHistory()
        {
            throw new NotImplementedException();
        }
    }
}
