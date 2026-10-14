namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetMoneyUnitCoefficient
    {
        public int BudgetMoneyUnitCoefficientId { get; set; }
        public int FiscalYearId { get; set; }
        public int MoneyUnitId { get; set; }
        public decimal Coefficient { get; set; }
    }
}
