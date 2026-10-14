using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetProposalType
    {
        [Description("قرارداد")]
        Contract = 1,

        [Description("کالا")]
        Product,

        [Description("خدمات")]
        Services
    }
}
