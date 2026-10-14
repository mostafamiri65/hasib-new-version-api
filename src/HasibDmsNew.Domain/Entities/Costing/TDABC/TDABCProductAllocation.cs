namespace HasibDmsNew.Domain.Entities.Costing.TDABC
{
    public class TDABCProductAllocation
    {
        public int TDABCProductAllocationId { get; set; }
        public int ActivityInProductStepId { get; set; }
        public int BranchId { get; set; }
        public int ActivityCount { get; set; }
        public int PeriodId { get; set; }
    }
}
