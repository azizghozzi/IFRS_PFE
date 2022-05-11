using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interface
{
    public interface IContractLocationRepository
    {
        IEnumerable<ContractLocation> GetContractLocations();
        object GetContractLocation();
    }
}
