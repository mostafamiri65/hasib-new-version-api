namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ProductCostingInPeriod
    {
        public decimal Costing { get; set; }
        public int ProductId { get; set; }
        public int PeriodId { get; set; }
        public decimal RealCosting { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
    }
}
