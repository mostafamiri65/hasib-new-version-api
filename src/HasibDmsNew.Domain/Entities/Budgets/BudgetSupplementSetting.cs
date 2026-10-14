using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetSupplementSetting
    {
        public BudgetSupplementSetting()
        {
            Branches = new List<BudgetSupplementSettingBranch>();
        }

        public int Id { get; set; }
        public int FiscalYearId { get; set; }
        public bool IncomeToCurrent { get; set; }
        public bool IncomeToCapital { get; set; }
        public bool IncomeToSalary { get; set; }
        public bool ResourceToCurrent { get; set; }
        public bool ResourceToCapital { get; set; }
        public bool ResourceToSalary { get; set; }
        public List<BudgetSupplementSettingBranch> Branches { get; set; }
    }
}
