using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class TDABCActivityCostAccounting
    {
        public long TDABCActivityCostAccountingId { get; set; }
        public int ActivityId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal CapacityCost { get; set; }
        public decimal RealCost { get; set; }

        public virtual FiscalYear FiscalYear { get; set; }
        public virtual Period Period { get; set; }
    }
}
