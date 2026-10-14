using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.WorkFlow;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    [Table("BudgetProposalRequestDetails")]
    public class BudgetProposalRequestDetail
    {
        public int Id { get; set; }
        public int BudgetProposalRequestId { get; set; }
        public BudgetProposalRequest BudgetProposalRequest { get; set; }
        public int WorkFlowStepId { get; set; }
        public WorkFlowStep WorkFlowStep { get; set; }
        public string Description { get; set; }
    }
}
