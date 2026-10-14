using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HasibDmsNew.Domain.Entities.Commons.Branchs;

namespace HasibDmsNew.Domain.Entities.UserManagement.Users
{
    [DisplayName("واحد سازمانی کاربر")]
    public class UserBranch
    {
        [Display(Name = "شناسه")]
        public int UserId { get; set; }

        [Display(Name = "کاربر")]
        public User User { get; set; }

        [Display(Name = "شناسه واحد سازمانی")]
        public int BranchId { get; set; }

        [Display(Name = "واحد سازمانی")]
        public Branch Branch { get; set; }
    }
}
