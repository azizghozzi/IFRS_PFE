using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class OutputContractLocationViewModel
    {
        internal object OutputContractLocation;

        public IEnumerable<OutputContractLocation> outputContractLocations { get; set; }
    }
}
