namespace HasibDmsNew.Domain.Entities.Costing.TDABC
{
    public class TDABCActivityCostAccounting
    {
        public long TDABCActivityCostAccountingId { get; set; }
        public int ActivityId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal CapacityCost { get; set; }
        public decimal RealCost { get; set; }
    }
}
