using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class OutputContractLocation
    {
        public int OutputContractLocationId { get; set; }
        [Display(Name = "RightOfUse")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal RightOfUse { get; set; }
        [Display(Name = "LeaseLiability")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LeaseLiability { get; set; }
        [Display(Name = "ROU_Depreciation")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ROU_Depreciation { get; set; }
        [Display(Name = "AccumulatedROU_Depreciation")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AccumulatedROU_Depreciation { get; set; }
        [Display(Name = "InterestExpenses")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal InterestExpenses { get; set; }
        [Display(Name = "LeasePayments")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LeasePayments { get; set; }
        [Display(Name = "LeaseLiabilityAmortization")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LeaseLiabilityAmortization { get; set; }
        [Display(Name = "CarryingAmount")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CarryingAmount { get; set; }
        [Display(Name = "AmortizationOfPeriod")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AmortizationOfPeriod { get; set; }
        [Display(Name = "ImpactModificationOfContract")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ImpactModificationOfContract { get; set; }
        [Display(Name = "InterestForPeriod")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal InterestForPeriod { get; set; }
        public int year { get; set; }

        public virtual ICollection<ContractLocationHistory> ContractLocationsHistory { get; set; }
    }
}
