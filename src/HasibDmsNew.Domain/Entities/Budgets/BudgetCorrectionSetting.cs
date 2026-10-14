using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrectionSetting
    {
        public BudgetCorrectionSetting()
        {
            Branches = new List<BudgetCorrectionSettingBranch>();
        }

        public int Id { get; set; }
        public int FiscalYearId { get; set; }
        public decimal CurrentPercent { get; set; }
        public short CurrentCount { get; set; }
        public decimal CurrentToCurrentPercent { get; set; }
        public decimal CurrentToCapitalPercent { get; set; }
        public decimal CurrentToSalaryPercent { get; set; }
        public decimal CapitalPercent { get; set; }
        public short CapitalCount { get; set; }
        public decimal CapitalToCurrentPercent { get; set; }
        public decimal CapitalToCapitalPercent { get; set; }
        public decimal CapitalToSalaryPercent { get; set; }
        public decimal SalaryPercent { get; set; }
        public short SalaryCount { get; set; }
        public decimal SalaryToCurrentPercent { get; set; }
        public decimal SalaryToCapitalPercent { get; set; }
        public decimal SalaryToSalaryPercent { get; set; }
        public List<BudgetCorrectionSettingBranch> Branches { get; set; }
    }
}
