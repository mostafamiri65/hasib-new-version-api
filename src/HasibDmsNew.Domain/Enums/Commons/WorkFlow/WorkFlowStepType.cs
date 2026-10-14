using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.WorkFlow
{
    public enum WorkFlowStepType
    {
        [Description("ارجاع به مرحله بعد")]
        OK = 1,
        [Description("عدم تایید")]
        NotOk,
        [Description("نیاز به اصلاح و بازگشت به مرحله قبل")]
        NeedCorrection,
        [Description("فقط مشاهده")]
        View,
        [Description("ذخیره اطلاعات")]
        DataEntry
    }
}
