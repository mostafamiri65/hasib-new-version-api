using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrection
    {
        public BudgetCorrection()
        {
            Allocations = new List<BudgetCorrectionAllocation>();
            Supplements = new List<BudgetCorrectionSupplement>();
            Documents = new List<BudgetCorrectionDocument>();
        }

        public int Id { get; set; }
        public int BudgetAllocationId { get; set; }
        public BudgetAllocation BudgetAllocation { get; set; }
        public int WorkFlowStepActivityId { get; set; }
        public byte WorkFlowStatus { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual List<BudgetCorrectionAllocation> Allocations { get; set; }
        public virtual List<BudgetCorrectionSupplement> Supplements { get; set; }
        public virtual List<BudgetCorrectionDocument> Documents { get; set; }
    }
}
