using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Evaluations
{
    public enum IndicatorRealScoreItemReason
    {
        [Description("عدم تکمیل فعالیت در مراحل قبل (عدم تحقق پیش نیازها)")]
        Reason1 = 1,
        [Description("عدم تامین اعتبار")]
        Reason2,
        [Description("فراهم نشدن مقدمات/ سازوکارهای اجرا")]
        Reason3,
        [Description("عدم نیاز به انجام فعالیت (عدم وقوع موضوع)")]
        Reason4,
        [Description("عدم تشکیل هیئت تحریریه")]
        Reason5,
        [Description("عدم صدور مجوزهای لازم")]
        Reason6,
        [Description("عدم تامین سخت افزار/ نرم افزار لازم")]
        Reason7,
        [Description("عدم اعزام به ماموریت بدلیل عدم دریافت تنخواه")]
        Reason8,
        [Description("عدم اعزام به ماموریت بدلیل شرایط جوی نامساعد")]
        Reason9,
        [Description("عدم اعزام به ماموریت بدلیل شیوع بیماری")]
        Reason10,
        [Description("سایر موارد")]
        Reason11
    }
}
