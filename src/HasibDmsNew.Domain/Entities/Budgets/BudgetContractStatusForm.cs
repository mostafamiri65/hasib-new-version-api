using System;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetContractStatusForm
    {
        public int Id { get; set; }
        public int WorkFlowStepActivityId { get; set; }
        public byte WorkFlowStatus { get; set; }
        public int BudgetFundingId { get; set; }
        public string SerialNumber { get; set; }
        public byte Month { get; set; }
        public decimal MonthlyPerformance { get; set; }
        public decimal PerformanceThanCurrent { get; set; }
        public decimal StatusPrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal StatusTotalPrice { get; set; }
        public decimal ReceivedPrice { get; set; }
        public DateTime? DoneTime { get; set; }
        public bool? IsFinancialApproval { get; set; }
    }
}
