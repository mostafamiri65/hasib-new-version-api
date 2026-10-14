using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Settings
{
    public enum StaffComputionType : byte
    {
        [Description("ساده")]
        Simple = 1,
        [Description("یکطرفه (آبشاری)")]
        OneWay = 2,
        [Description("دوطرفه")]
        DoubleWay = 3,
        UnKnown = 4
    }
}
