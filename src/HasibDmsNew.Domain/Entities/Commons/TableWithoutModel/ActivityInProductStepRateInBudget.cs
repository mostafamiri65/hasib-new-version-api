namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ActivityInProductStepRateInBudget
    {
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int ProductStepId { get; set; }
        public int ActivityId { get; set; }
        public decimal ConsumptionActivityProductStep { get; set; }
    }
}
