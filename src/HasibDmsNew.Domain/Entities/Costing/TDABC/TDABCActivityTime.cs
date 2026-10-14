namespace HasibDmsNew.Domain.Entities.Costing.TDABC
{
    public class TDABCActivityTime
    {
        public int TDABCActivityTimeId { get; set; }
        public int ActivityId { get; set; }
        public int PeriodId { get; set; }
        public int ActivityTime { get; set; }
        public int BranchId { get; set; }
    }
}
