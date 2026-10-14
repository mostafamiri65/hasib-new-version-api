using System;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetSupplementLog
    {
        public int Id { get; set; }
        public int BudgetSupplementId { get; set; }
        public decimal Price { get; set; }
        public int MoneyUnitId { get; set; }
        public int UserId { get; set; }
        public byte Type { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
