using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Budgets;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowStepActivityLog
    {
        public WorkFlowStepActivityLog()
        {
            BudgetCorrectionAllocationStepLog = new List<BudgetCorrectionAllocationStepLog>();
            BudgetCorrectionSupplementStepLog = new List<BudgetCorrectionSupplementStepLog>();
        }

        public int Id { get; set; }
        public WorkFlowStep WorkFlowStep { get; set; }
        public int WorkFlowStepId { get; set; }
        public string WorkFlowStepTitle { get; set; }

        public WorkFlowStepActivity WorkFlowStepActivity { get; set; }
        public int WorkFlowStepActivityId { get; set; }

        public string Roles { get; set; }
        public int UserId { get; set; }

        public string Description { get; set; }
        public int BranchId { get; set; }
        public DateTime CreationTime { get; set; }
        public byte Status { get; set; }
        public byte Step { get; set; }
        public bool IsTemp { get; set; }
        public int? NextBranchId { get; set; }
        public string NextCostCenterIds { get; set; }
        public int CostCenterId { get; set; }
        public int? PreviousStepId { get; set; }
        public Guid UniqueStepId { get; set; }
        public int? WorkFlowFormId { get; set; }
        public string FormInfo { get; set; }
        public bool? AutoInsert { get; set; }

        public virtual BudgetFundingStepLog BudgetFundingStepLog { get; set; }
        public virtual BudgetCorrectionStepLog BudgetCorrectionStepLog { get; set; }
        public virtual List<BudgetCorrectionAllocationStepLog> BudgetCorrectionAllocationStepLog { get; set; }
        public virtual List<BudgetCorrectionSupplementStepLog> BudgetCorrectionSupplementStepLog { get; set; }
    }
}
