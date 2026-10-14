using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetProposalSuggestionType
    {
        [Description("جاری")]
        Current = 1,

        [Description("سرمایه ای")]
        Capital
    }
}
