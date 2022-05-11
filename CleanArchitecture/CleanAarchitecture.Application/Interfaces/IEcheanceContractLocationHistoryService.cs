using System;
using System.Collections.Generic;
using System.Text;
using CleanAarchitecture.Application.ViewModels;

namespace CleanAarchitecture.Application.Interfaces
{
    public interface IEcheanceContractLocationHistoryService
    {
        EcheanceContractLocationHistoryViewModel GetEcheanceContractLocationHistory();
    }
}
