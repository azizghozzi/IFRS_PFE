using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class EcheanceContractLocationHistoryViewModel
    {
        internal object EcheanceContractLocationHistory;

        public IEnumerable<EcheanceContractLocationHistory> echeanceContractLocationHistories { get; set; }
    }
}
