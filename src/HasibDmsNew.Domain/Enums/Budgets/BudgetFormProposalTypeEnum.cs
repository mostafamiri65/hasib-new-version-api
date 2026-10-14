using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetFormProposalTypeEnum
    {
        [Description("سایر")]
        None = 0,

        [Description("جاری")]
        CurrentType = 1,

        [Description("سرمایه ای")]
        capitalType = 2
    }
}
