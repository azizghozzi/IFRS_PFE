using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class ContractLocationViewModel
    {
        internal object ContractLocation;

        public IEnumerable<ContractLocation> contractLocations { get; set; }
    }
}
