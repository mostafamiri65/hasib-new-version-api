namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ProcessCostingInPeriod
    {
        public int ProcessId { get; set; }
        public int PeriodId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public decimal RealCosting { get; set; }
        public decimal Costing { get; set; }
    }
}
