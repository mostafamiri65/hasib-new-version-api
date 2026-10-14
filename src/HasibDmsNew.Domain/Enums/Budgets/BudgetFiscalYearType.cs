using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetFiscalYearType
    {
        [Description("جاری")]
        Current = 1,

        [Description("سرمایه ای")]
        Capital,

        [Description("حقوق و دستمزد")]
        Salary
    }
}
