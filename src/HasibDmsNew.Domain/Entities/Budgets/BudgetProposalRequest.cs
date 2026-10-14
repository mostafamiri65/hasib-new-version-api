using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    [Table("BudgetProposalRequests")]
    public class BudgetProposalRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal RequestMount { get; set; }
        public virtual ICollection<BudgetProposalRequestDetail> BudgetProposalRequestDetails { get; set; }
    }
}
