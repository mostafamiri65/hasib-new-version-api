using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Enums.Commons.Branchs
{
    /// <summary>
    /// واحد سازمانی ستادی است یا عملیاتی
    /// </summary>
    public enum BranchOperationType : byte
    {
        [Display(Name = "عملیاتی")]
        Operation = 1,

        [Display(Name = "ستادی")]
        Staff = 2
    }
}
