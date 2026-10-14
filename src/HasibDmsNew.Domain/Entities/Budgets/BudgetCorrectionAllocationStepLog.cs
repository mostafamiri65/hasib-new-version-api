using System;
using HasibDmsNew.Domain.Entities.WorkFlow;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrectionAllocationStepLog
    {
        public int Id { get; set; }
        public int WorkFlowStepActivityLogId { get; set; }
        public virtual WorkFlowStepActivityLog WorkFlowStepActivityLog { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public byte PeriodIndex { get; set; }
        public byte Type { get; set; }
        public int BudgetLineId { get; set; }
        public int AllocationId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Percent { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
