using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum InitialBudgetOperationType
    {
        [Display(Name = "پیش بینی")]
        Forecast = 1,

        [Display(Name = "افزایشی")]
        Incremental = 2
    }
}
