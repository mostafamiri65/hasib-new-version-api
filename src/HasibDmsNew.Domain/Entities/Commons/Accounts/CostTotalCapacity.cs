namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    public class CostTotalCapacity
    {
        public int CostTotalCapacityId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public int CostId { get; set; }
        public int MainCostCenterId { get; set; }
        public decimal Capacity { get; set; }
    }
}
