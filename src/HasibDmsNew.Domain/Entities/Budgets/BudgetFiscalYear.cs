using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetFiscalYear
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte YearSection { get; set; }
        public byte Type { get; set; }
        public int FiscalYearId { get; set; }
        public virtual List<BudgetPeriod> Periods { get; set; }
        public virtual ICollection<BudgetFiscalYearBranch> Branchs { get; set; }
    }
}
