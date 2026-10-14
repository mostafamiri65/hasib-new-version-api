using HasibDmsNew.Domain.Entities.Commons.Products;
using HasibDmsNew.Domain.Entities.Strategics.Goals;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class ProductInGoalInBudget
    {
        public long ProductInGoalInBudgetId { get; set; }
        public int ProductId { get; set; }
        public int GoalId { get; set; }
        public int BranchId { get; set; }
        public decimal Count { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public Product Product { get; set; }
        public Goal Goal { get; set; }
    }
}
