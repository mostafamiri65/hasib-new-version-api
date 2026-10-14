namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ProductStepBudget
    {
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int ProcessId { get; set; }
        public int ProductId { get; set; }
        public int ProductStepId { get; set; }
        public decimal ActivityBudget { get; set; }
        public decimal DirectCostBudget { get; set; }
        public decimal DirectWageBudget { get; set; }
        public decimal StaffBudget { get; set; }
        public decimal TotalBudget { get; set; }
    }
}
