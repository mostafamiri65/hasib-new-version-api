using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.BudgetNew
{
    [Table("BudgetProposalSteps")]
    public class BudgetProposalStep
    {
        public int Id { get; set; }
        public int BudgetProposalId { get; set; }
        public int CurrentStepId { get; set; }
        public int NextStepId { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
        public int CostCenterId { get; set; }
    }
}
