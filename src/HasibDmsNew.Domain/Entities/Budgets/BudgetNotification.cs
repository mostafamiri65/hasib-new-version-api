using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetNotification
    {
        public int Id { get; set; }
        public int CostId { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public int FiscalYearId { get; set; }
        public decimal ApprovedBudget { get; set; }
        public decimal? AllocatedBudget { get; set; }
        public decimal? RemainingBudget => ApprovedBudget - (AllocatedBudget ?? 0);
        public virtual ICollection<BudgetAllocate> Items { get; set; }
    }
}
