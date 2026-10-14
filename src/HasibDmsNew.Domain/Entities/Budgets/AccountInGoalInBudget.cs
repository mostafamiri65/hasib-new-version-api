namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class AccountInGoalInBudget
    {
        public long AccountInGoalInBudgetId { get; set; }
        public int CostId { get; set; }
        public int GoalId { get; set; }
        public int BranchId { get; set; }
        public decimal Count { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
    }
}
