using System;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetAllocationLog
    {
        public int Id { get; set; }
        public int BudgetAllocationId { get; set; }
        public int UserId { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsRegister { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal CorrectiveCount { get; set; }
        public decimal CorrectiveTotalPrice { get; set; }
        public decimal BudgetPercent { get; set; }
    }
}
