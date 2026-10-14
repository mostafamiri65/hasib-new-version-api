using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HasibDmsNew.Domain.Enums.UserManagement.Users;

namespace HasibDmsNew.Domain.Entities.UserManagement.Users
{
    [DisplayName("اطلاعات ورود کاربر")]
    public class LoginEvent
    {
        [Display(Name = "شناسه")]
        public long LoginEventId { get; set; }

        [Display(Name = "شناسه کاربر")]
        public int? UserId { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime EventDate { get; set; }

        [Display(Name = "نوع")]
        public LoginEventType Type { get; set; }

        [Display(Name = "تاریخ فارسی")]
        public string PersianEventDate { get; set; }

        [Display(Name = "نام کاربری وارد شده")]
        public string UserNameEnter { get; set; }

        [Display(Name = "رمز عبور وارد شده")]
        public string PassEnter { get; set; }

        [Display(Name = "IP کاربر")]
        public string UserIp { get; set; }
    }
}
