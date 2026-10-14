using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetProposal
    {
        public BudgetProposal()
        {
            Details = new List<BudgetProposalDetail>();
        }

        public int Id { get; set; }
        public int? WorkFlowStepActivityId { get; set; }
        public byte? WorkFlowStatus { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public virtual List<BudgetProposalDetail> Details { get; set; }
    }
}
