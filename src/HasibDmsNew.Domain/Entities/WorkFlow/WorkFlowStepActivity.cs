using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Budgets;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowStepActivity
    {
        public WorkFlowStepActivity()
        {
            WorkFlowStepActivityLogs = new List<WorkFlowStepActivityLog>();
            WorkFlowStepActivityForms = new List<WorkFlowStepActivityForm>();
            BudgetAllocates = new List<BudgetAllocate>();
            BudgetProposals = new List<BudgetProposal>();
            BudgetFundings = new List<BudgetFunding>();
            BudgetCorrections = new List<BudgetCorrection>();
            BudgetContractStatusForms = new List<BudgetContractStatusForm>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public byte CurrentStep { get; set; }
        public string Roles { get; set; }

        public WorkFlow WorkFlow { get; set; }
        public int WorkFlowId { get; set; }

        public WorkFlowStep WorkFlowStep { get; set; }
        public int WorkFlowStepId { get; set; }

        public byte WorkFlowType { get; set; }
        public byte Status { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? NeedTime { get; set; }
        public DateTime? SystemicStartDate { get; set; }
        public string WorkFlowStepTitle { get; set; }
        public int BranchID { get; set; }
        public string CostCenterIds { get; set; }
        public string PrevBranchIds { get; set; }
        public string PrevCostCenterIds { get; set; }
        public Guid UniqueStepId { get; set; }
        public bool IsLock { get; set; }

        public List<WorkFlowStepActivityLog> WorkFlowStepActivityLogs { get; set; }
        public List<WorkFlowStepActivityForm> WorkFlowStepActivityForms { get; set; }
        public List<BudgetAllocate> BudgetAllocates { get; set; }
        public List<BudgetProposal> BudgetProposals { get; set; }
        public List<BudgetContractStatusForm> BudgetContractStatusForms { get; set; }
        public List<BudgetFunding> BudgetFundings { get; set; }
        public List<BudgetCorrection> BudgetCorrections { get; set; }
    }
}
