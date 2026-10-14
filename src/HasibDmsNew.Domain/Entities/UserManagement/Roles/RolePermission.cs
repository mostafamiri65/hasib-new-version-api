using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Entities.UserManagement.Roles
{
    [DisplayName("دسترسی نقش")]
    public class RolePermission
    {
        [Display(Name = "شناسه نقش")]
        public int RoleId { get; set; }

        [Display(Name = "شناسه دسترسی")]
        public int PermissionId { get; set; }
    }
}
