namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ActivityCostRateInBudget
    {
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int CostId { get; set; }
        public int ActivityId { get; set; }
        public decimal ConsumptionCostActivity { get; set; }
        public decimal RealRate { get; set; }
        public decimal InflationPercentage { get; set; }
        public decimal MoneyUnitCoefficient { get; set; }
    }
}
