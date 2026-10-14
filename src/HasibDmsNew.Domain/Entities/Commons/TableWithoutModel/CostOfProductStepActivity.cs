namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class CostOfProductStepActivity
    {
        public int ProductStepId { get; set; }
        public int ActivityId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public decimal ConsumptionActivityProductStep { get; set; }
        public decimal Completed { get; set; }
        public decimal OneCoefficient { get; set; }
        public decimal TotalCoefficient { get; set; }

        public virtual CostOfProductStepActivity CostOfProductStepActivities1 { get; set; }
        public virtual CostOfProductStepActivity CostOfProductStepActivity1 { get; set; }
    }
}
