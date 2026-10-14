using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetLineType
    {
        [Description("معاونت / مدیریت")]
        Management = 200,

        [Description("جاری")]
        Current = 1,

        [Description("سرمایه ای")]
        Capital = 2,

        [Description("حقوق و دستمزد")]
        Salary = 3
    }
}
