using HasibDmsNew.Domain.Entities.Commons.Activities;

namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class CostOfActivityCost
    {
        public int ActivityId { get; set; }
        public int CostId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public decimal CostActivityAssigned { get; set; }
        public decimal RealRate { get; set; }
        public decimal Rate { get; set; }
        public decimal ActivityTotal { get; set; }
        public decimal ConsumptionCostActivity { get; set; }
        public decimal InflationPercentage { get; set; }
        public decimal MoneyUnitCoefficient { get; set; }

        public virtual Activity Activity { get; set; }
    }
}
