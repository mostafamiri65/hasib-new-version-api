namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class BranchBudget
    {
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal VariableBudget { get; set; }
        public decimal FixedBudget { get; set; }
        public decimal TotalBudget { get; set; }
        public int BasePeriodId { get; set; }
    }
}
