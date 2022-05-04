using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    internal class ContractLocationHistory
    {
        public int idContractLocationHistory { get; set; }
        public DateTime UpdateDate { get; set; }
        public int ContractReference { get; set; }
        public int DurationRetainedUnderIFRS16 { get; set; }
        public int AnnulRent { get; set; }
        public int PayementFrequency { get; set; }
        public int MonthsNumber { get; set; }
        public int Annulncrease { get; set; }
        public int IncreaseFrequency { get; set; }
        public int increaseDate { get; set; }
        public string Comment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DiscountRate { get; set; }
        public DateTime PrepaidExpensesPayementDate { get; set; }
        public string PrepaidExpensesPeriodCovered { get; set; }
        public int RenewalOption_Id { get; set; }
        public int tenant_id { get; set; }
        public DateTime DateExcuteUpdate { get; set; }
        public DateTime DateReference { get; set; }
    }
}
