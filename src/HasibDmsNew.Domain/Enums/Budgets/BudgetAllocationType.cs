using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Budgets
{
    public enum BudgetAllocationType
    {
        [Description("ثبت موقت")]
        TemporaryRegistration = 1,

        [Description("در حال بررسی")]
        Pending,

        [Description("رد درخواست")]
        RequestRejection,

        [Description("تایید درخواست")]
        ConfirmationInformation,

        [Description("عدم تایید اطلاعات")]
        NonConfirmationInformation
    }
}
