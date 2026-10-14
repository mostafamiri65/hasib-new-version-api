using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.WorkFlow
{
    public enum WorkFlowStepActivityType
    {
        [Description("باز")]
        Open = 1,
        [Description("تکمیل شده")]
        Done,
        [Description("کنسل شده")]
        Faild,
        [Description("نیاز به اصلاح و بازگشت به مرحله قبل")]
        NeedCorrection
    }
}
