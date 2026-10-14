namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class PriceCostRateInBudget
    {
        public int BudgetId { get; set; }
        public int CostId { get; set; }
        public int FiscalYearId { get; set; }
        public decimal PriceRate { get; set; }
        public decimal RealPriceRate { get; set; }
    }
}
