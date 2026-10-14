using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum Incometype : byte
    {
        [Display(Name = "درآمد")]
        Account = 1,

        [Display(Name = "برنامه")]
        Product = 2
    }
}
