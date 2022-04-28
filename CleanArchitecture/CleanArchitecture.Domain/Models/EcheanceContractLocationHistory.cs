using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    internal class EcheanceContractLocationHistory
    {
        public int id { get; set; }
        public DateTime PayementDate { get; set; }

        public int CumulativeMonths { get; set; }
        public int Leasepayment { get; set; }
        public int PresentValue { get; set; }
        public int NetDebtInitialValue { get; set; }
        public string AnnualInterest { get; set; }
        public int CapitalRepayment { get; set; }
        public int NetDebtEndingValue { get; set; }
        public string YearlyDepreciationAmount { get; set; }
        public string Accumulated_Depreciation { get; set; }
        public string CarryingAmount { get; set; }
    }
}
