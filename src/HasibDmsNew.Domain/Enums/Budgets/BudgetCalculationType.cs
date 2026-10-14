using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetCalculationTypeEnum : byte
    {
        [Description("بودجه بر مبنای صفر(Zero Base Budgeting)")]
        ZBB = 1,

        [Description("بودجه ریزی افزایشی (ABB)")]
        ABB = 2,

        [Description("بودجه ریزی مبتنی بر عملکرد (PBB)")]
        PBB = 3
    }
}
