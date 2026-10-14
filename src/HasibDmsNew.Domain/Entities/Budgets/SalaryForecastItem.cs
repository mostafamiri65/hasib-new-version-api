namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class SalaryForecastItem
    {
        public int Id { get; set; }
        public SalaryForecast SalaryForecast { get; set; }
        public int SalaryForecastId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public int BudgetLineId { get; set; }
        public decimal BasePrice { get; set; }
        public int BaseMonth { get; set; }
        public decimal Percent { get; set; }
        public decimal BaseSaraneh { get; set; }
        public decimal BudgetSaraneh { get; set; }
        public decimal TotalBudget { get; set; }
        public int Month { get; set; }
        public int? BeforeFiscalYearId { get; set; }
    }
}
