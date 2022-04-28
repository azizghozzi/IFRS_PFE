using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    internal class OutputContractLocation
    {
        public int Id { get; set; }
        public string RightOfUse { get; set; }
        public string LeaseLiability { get; set; }
        public string ROU_Depreciation { get; set; }
        public string AccumulatedROU_Depreciation { get; set; }
        public string InterestExpenses { get; set; }
        public int LeasePayments { get; set; }
        public int LeaseLiabilityAmortization { get; set; }
        public int CarryingAmount { get; set; }
        public int AmortizationOfPeriod { get; set; }
        public int InterestForPeriod { get; set; }
        public int year { get; set; }
    }
}
