using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class EcheanceContractLocation
    {
        public int EcheanceContractLocationid { get; set; }
        public DateTime PayementDate { get; set; }

        public int CumulativeMonths { get; set; }
        [Display(Name = "Leasepayment")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Leasepayment { get; set; }
        [Display(Name = "PresentValue")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PresentValue { get; set; }
        [Display(Name = "NetDebtInitialValue")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NetDebtInitialValue { get; set; }
        [Display(Name = "AnnualInterest")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AnnualInterest { get; set; }
        [Display(Name = "CapitalRepayment")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CapitalRepayment { get; set; }
        [Display(Name = "NetDebtEndingValue")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NetDebtEndingValue { get; set; }
        [Display(Name = "YearlyDepreciationAmount")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal YearlyDepreciationAmount { get; set; }
        [Display(Name = "Accumulated_Depreciation")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Accumulated_Depreciation { get; set; }
        [Display(Name = "CarryingAmount")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CarryingAmount { get; set; }

        public virtual ICollection<ContractLocation> ContractLocations { get; set; }
    }
}
