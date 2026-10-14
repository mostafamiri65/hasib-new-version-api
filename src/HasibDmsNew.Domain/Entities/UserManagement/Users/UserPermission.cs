using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Entities.UserManagement.Users
{
    [DisplayName("دسترسی کاربر")]
    public class UserPermission
    {
        [Display(Name = "شناسه کاربر")]
        public int UserId { get; set; }

        [Display(Name = "شناسه دسترسی")]
        public int PermissionId { get; set; }
    }
}
