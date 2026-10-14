using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.BudgetNew
{
    [Table("WorkflowLocks")]
    public class WorkflowLock
    {
        public int Id { get; set; }
        public int WorkflowId { get; set; }
        public int CostCenterId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsLock { get; set; }
    }
}
