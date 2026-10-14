using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Settings
{
    public enum ActivityStructureComputationType : byte
    {
        [Description("زیر فعالیت")]
        ActivityItem = 1,
        [Description("فعالیت اصلی")]
        Activity = 2,
        [Description("نوع فعالیت")]
        TypeActivity = 3
    }
}
