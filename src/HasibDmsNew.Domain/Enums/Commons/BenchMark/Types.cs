using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.BenchMark
{
    public enum Type
    {
        [Description("فعالیت")]
        Activity = 1,

        [Description("برنامه")]
        Program = 2,

        [Description("مواد")]
        Material = 3
    }
}
