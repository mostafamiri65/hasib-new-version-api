using System;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetPeriod
    {
        public byte Index { get; set; }
        public string Title { get; set; }
        public int BudgetFiscalYearId { get; set; }
        public int FiscalYearId { get; set; }
        public decimal Percent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte Month { get; set; }
    }
}
