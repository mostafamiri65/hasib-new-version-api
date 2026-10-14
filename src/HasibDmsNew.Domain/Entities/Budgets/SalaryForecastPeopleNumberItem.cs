namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class SalaryForecastPeopleNumberItem
    {
        public int Id { get; set; }
        public SalaryForecastPeopleNumber SalaryForecastPeopleNumber { get; set; }
        public int SalaryForecastPeopleNumberId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public int BudgetLineId { get; set; }
        public int BasePeopleNumber { get; set; }
        public int IncreaseCount { get; set; }
        public int DecreaseCount { get; set; }
        public int CurrentPeopleNumber { get; set; }
        public int? BeforeFiscalYearId { get; set; }
    }
}
