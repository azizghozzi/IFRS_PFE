using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class EcheanceContractLocationViewModel
    {
        internal object EcheanceContractLocation;

        public IEnumerable<EcheanceContractLocation> echeanceContractLocations { get; set; }
    }
}
