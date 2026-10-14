using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.UserManagement.Users
{
    public enum LoginEventType : byte
    {
        [Description("موفق")]
        Success = 1,

        [Description("عدم وجود نام کاربری")]
        NotFoundUserName = 2,

        NotFoundPassword = 7,

        [Description("کاربر غیر فعال /مسدود")]
        LockOrDeActive = 3,

        [Description("رمز اشتباه بیش از حد")]
        OverFailedCount = 4,

        [Description("عدم دسترسی برای آی پی کاربر")]
        NotAccessUserIP = 5,

        [Description(" عدم تطابق کد فعالسازی")]
        InvalidActivationCode = 6,

        [Description("مسدود موقت")]
        TemporarilyBlocked = 8
    }
}
