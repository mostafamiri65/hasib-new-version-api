using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class SalaryForecast
    {
        public SalaryForecast()
        {
            Items = new List<SalaryForecastItem>();
        }

        public int Id { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public decimal BasePrice { get; set; }
        public int BaseMonth { get; set; }
        public decimal Percent { get; set; }
        public int Month { get; set; }
        public decimal BaseSaraneh { get; set; }
        public decimal BudgetSaraneh { get; set; }
        public decimal TotalBudget { get; set; }
        public int? BeforeFiscalYearId { get; set; }
        public List<SalaryForecastItem> Items { get; set; }
    }
}
