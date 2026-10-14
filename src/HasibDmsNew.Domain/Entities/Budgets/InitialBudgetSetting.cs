using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class InitialBudgetSetting
    {
        public InitialBudgetSetting()
        {
            Branches = new List<InitialBudgetSettingBranch>();
        }

        public int Id { get; set; }
        public int FiscalYearId { get; set; }
        public string Title { get; set; }
        public int BaseFiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public bool ByUserInfo { get; set; }
        public byte SupportOperationType { get; set; }
        public byte CurrentOperationType { get; set; }
        public byte CapitalOperationType { get; set; }
        public byte SalaryOperationType { get; set; }
        public List<InitialBudgetSettingBranch> Branches { get; set; }
    }
}
