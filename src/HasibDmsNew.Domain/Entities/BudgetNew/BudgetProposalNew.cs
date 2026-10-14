using System;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Enums.BudgetProposal;

namespace HasibDmsNew.Domain.Entities.BudgetNew
{
    [Table("BudgetProposalNew")]
    public class BudgetProposalNew
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int FiscalYearId { get; set; }
        public int RequestingCostCenterId { get; set; }
        public int WorkFlowId { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public DateTime RequestedDate { get; set; }
        public BudgetProposalStatus Status { get; set; }
        public int CurrentStepId { get; set; }
    }
}
