using HasibDmsNew.Domain.Entities.Commons.Branchs;
using HasibDmsNew.Domain.Entities.Commons.Years;
using HasibDmsNew.Domain.Entities.Costing;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    public class CostRateInPeriod
    {
        public int CostRateInPeriodId { get; set; }

        public decimal Rate { get; set; }

        public decimal RealRate { get; set; }

        public decimal Price { get; set; }
        public decimal CalculatePrice { get; set; }

        public decimal Capacity { get; set; }
        public decimal AssignedCapacity { get; set; }

        public decimal InflationPercentage { get; set; }

        public int CostId { get; set; }
        public Cost Cost { get; set; }

        public int MainCostCenterId { get; set; }
        public MainCostCenter MainCostCenter { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public int PeriodId { get; set; }
        public Period Period { get; set; }
    }
}
