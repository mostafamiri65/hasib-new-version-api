namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class BudgetFixedCostHistory
    {
        public int BudgetFixedCostId { get; set; }
        public int CostId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public decimal LastYearAmount { get; set; }
        public decimal ChangingPercent { get; set; }
        public decimal ChangingFixedAmount { get; set; }
        public decimal TotalFixedBudget { get; set; }
        public int PeriodId { get; set; }
        public decimal PeriodTotalFixedBudget { get; set; }
    }
}
