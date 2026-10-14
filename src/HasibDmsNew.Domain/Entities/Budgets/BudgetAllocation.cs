using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetAllocation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte Type { get; set; }
        public int FiscalYearId { get; set; }
        public int BudgetFiscalYearId { get; set; }
        public byte BudgetPeriodIndex { get; set; }
        public int BudgetProposalId { get; set; }
        public int BudgetLineId { get; set; }
        public int BudgetProposalDetailId { get; set; }
        public int? BudgetProposalSubDetailId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public int MoneyUnitId { get; set; }
        public int? BenchMarkId { get; set; }
        public decimal Count { get; set; }
        public decimal MainTotalPrice { get; set; }
        public decimal MainUnitPrice { get; set; }
        public decimal MainCount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal CorrectiveCount { get; set; }
        public decimal CorrectiveTotalPrice { get; set; }
        public decimal BudgetPercent { get; set; }
        public bool IsRegister { get; set; }
        public virtual List<BudgetAllocationLog> Logs { get; set; }
    }
}
