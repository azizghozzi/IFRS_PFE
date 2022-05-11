using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class ContractLocationHistory
    {
        public int ContractLocationHistoryId { get; set; }
        public DateTime UpdateDate { get; set; }
        public String ContractReference { get; set; }
        [Display(Name = "DurationRetainedUnderIFRS16")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DurationRetainedUnderIFRS16 { get; set; }

        [Display(Name = "AnnulRent")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AnnulRent { get; set; }
        public int PayementFrequency { get; set; }

        public int MonthsNumber { get; set; }

        [Display(Name = "Annulncrease")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Annulncrease { get; set; }
        public int IncreaseFrequency { get; set; }
        public DateTime increaseDate { get; set; }
        public string Comment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Display(Name = "DiscountRate")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountRate { get; set; }
        public DateTime PrepaidExpensesPayementDate { get; set; }
        [Display(Name = "PrepaidExpensesPeriodCovered")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrepaidExpensesPeriodCovered { get; set; }
        public int RenewalOption_Id { get; set; }
        public int tenant_id { get; set; }
        public DateTime DateExcuteUpdate { get; set; }
        public DateTime DateReference { get; set; }

        // Nivagation proproties
  
        public virtual ICollection<ContractLocation> ContractLocations { get; set; }

        public virtual EcheanceContractLocationHistory EcheanceContractLocationHistory { get; set; }

        public virtual OutputContractLocation OutputContractLocation { get; set; }

    }
}
