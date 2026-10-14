namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCostInflationCoefficient
    {
        public int BudgetCostInflationCoefficientId { get; set; }
        public int FiscalYearId { get; set; }
        public int CostId { get; set; }
        public decimal InflationCoefficient { get; set; }
    }
}
