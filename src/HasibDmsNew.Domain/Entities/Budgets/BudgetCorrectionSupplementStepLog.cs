using System;
using HasibDmsNew.Domain.Entities.WorkFlow;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrectionSupplementStepLog
    {
        public int Id { get; set; }
        public int WorkFlowStepActivityLogId { get; set; }
        public virtual WorkFlowStepActivityLog WorkFlowStepActivityLog { get; set; }
        public byte Type { get; set; }
        public int SupplementId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Percent { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
