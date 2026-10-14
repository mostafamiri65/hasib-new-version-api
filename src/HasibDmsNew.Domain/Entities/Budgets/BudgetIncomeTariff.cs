namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetIncomeTariff
    {
        public long BudgetIncomeTariffId { get; set; }
        public int FiscalYearId { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public decimal TariffRateLastYear { get; set; }
        public decimal InflationRate { get; set; }
        public decimal BudgetedTariffRate { get; set; }
        public decimal BudgetedFinalTariffRate { get; set; }
    }
}
