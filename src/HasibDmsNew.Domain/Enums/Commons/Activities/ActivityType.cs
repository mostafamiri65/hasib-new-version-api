using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Activities
{
    public enum ActivityType
    {
        [Description("فعالیت عملیاتی")]
        Functional = 1,

        [Description("فعالیت پشتیبانی")]
        Support = 2
    }

    public enum ActivityAlternation
    {
        [Description("روزانه")]
        Daily = 1,
        [Description("ماهانه")]
        Monthly = 2,
        [Description("فصلی")]
        Quarterly = 3,
        [Description("سالانه")]
        Annually = 4
    }
}
