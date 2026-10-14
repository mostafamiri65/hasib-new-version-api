using System;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetContract
    {
        public int BudgetFundingId { get; set; }
        public string Title { get; set; }
        public string Contractor { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public decimal? Count { get; set; }
        public int? BenchMarkId { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ResourceId { get; set; }
        public decimal? Price { get; set; }
        public int? MoneyUnitId { get; set; }
        public string Description { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Progress { get; set; }
        public decimal? AllocatedPrice { get; set; }
    }
}
