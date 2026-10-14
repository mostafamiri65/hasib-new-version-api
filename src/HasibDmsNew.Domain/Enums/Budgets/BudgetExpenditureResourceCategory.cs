using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetExpenditureResourceCategory : byte
    {
        [Description("مصارف")]
        Expenditure = 1,

        [Description("منابع")]
        Resource = 2
    }
}
