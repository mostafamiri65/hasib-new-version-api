namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public partial class BudgetIncomeTariffAccountHistory
    {
        public long BudgetIncomeTariffAccountId { get; set; }
        public int FiscalYearId { get; set; }
        public int CostId { get; set; }
        public int BranchId { get; set; }
        public decimal TariffRateLastYear { get; set; }
        public decimal InflationRate { get; set; }
        public decimal BudgetedTariffRate { get; set; }
        public decimal BudgetedFinalTariffRate { get; set; }
    }
}
