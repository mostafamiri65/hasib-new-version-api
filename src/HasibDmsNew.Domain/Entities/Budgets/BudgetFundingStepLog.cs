using System;
using HasibDmsNew.Domain.Entities.WorkFlow;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetFundingStepLog
    {
        public int WorkFlowStepActivityLogId { get; set; }
        public virtual WorkFlowStepActivityLog WorkFlowStepActivityLog { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public string IdentityCode { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
