using System;
using HasibDmsNew.Domain.Entities.WorkFlow;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrectionStepLog
    {
        public int WorkFlowStepActivityLogId { get; set; }
        public virtual WorkFlowStepActivityLog WorkFlowStepActivityLog { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
