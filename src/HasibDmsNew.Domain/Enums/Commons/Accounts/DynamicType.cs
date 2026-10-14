using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Accounts
{
    public enum DynamicType : byte
    {
        [Description("ثابت")]
        Const = 1,

        [Description("متغیر")]
        Variable = 2
    }
}
