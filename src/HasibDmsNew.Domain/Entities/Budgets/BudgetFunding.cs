using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetFunding
    {
        public BudgetFunding()
        {
            Documents = new List<BudgetFundingDocument>();
        }

        public int Id { get; set; }
        public int BudgetAllocationId { get; set; }
        public BudgetAllocation BudgetAllocation { get; set; }
        public int WorkFlowStepActivityId { get; set; }
        public byte WorkFlowStatus { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public string IdentityCode { get; set; }
        public string ReferCode { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DoneTime { get; set; }
        public bool? IsFinancialApproval { get; set; }
        public virtual List<BudgetFundingDocument> Documents { get; set; }
    }
}
