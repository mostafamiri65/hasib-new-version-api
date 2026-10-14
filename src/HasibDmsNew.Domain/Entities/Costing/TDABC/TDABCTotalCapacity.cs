namespace HasibDmsNew.Domain.Entities.Costing.TDABC
{
    public class TDABCTotalCapacity
    {
        public int TDABCTotalCapacityId { get; set; }
        public int BranchId { get; set; }
        public int PeriodId { get; set; }
        public decimal Capacity { get; set; }
    }
}
