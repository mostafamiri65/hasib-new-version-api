using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.UserManagement.Users
{
    public enum LoginType
    {
        [Description("نام کاربری/کلمه عبور")]
        UserNamePassword = 1,

        [Description("دوفاکتوری")]
        TowFactor = 2,

        [Description("هردو")]
        both = 3
    }
}
