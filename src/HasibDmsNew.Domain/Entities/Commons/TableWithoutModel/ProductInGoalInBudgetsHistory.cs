namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ProductInGoalInBudgetsHistory
    {
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int ProductId { get; set; }
        public int GoalId { get; set; }
        public decimal Count { get; set; }
    }
}
