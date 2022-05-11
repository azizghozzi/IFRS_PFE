using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanAarchitecture.Application.ViewModels
{
    public class contractLocationHistoryViewModel
    {
        internal object contractLocationHistory;

        public IEnumerable<ContractLocationHistory> contractLocationHistories { get; set; }
    }
}
