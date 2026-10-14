using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using HasibDmsNew.Domain.Entities.Costing;

namespace HasibDmsNew.Domain.Entities.UserManagement.Users
{
    /// <summary>
    /// کاربر
    /// </summary>
    [DisplayName("کاربران")]
    public class User
    {
        [Display(Name = "شناسه")]
        public int UserId { get; set; }

        [Display(Name = "نام")]
        public string FullName { get; set; }

        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

        [Display(Name = "تعداد شکست")]
        public byte AccessFailedCount { get; set; }

        public byte LoginFailedCount { get; set; }

        [Display(Name = "بلاک شده")]
        public bool Islock { get; set; }

        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }

        [Display(Name = "پست الکترونیکی")]
        public string Email { get; set; }

        [Display(Name = "کدتایید")]
        public string ActivationCode { get; set; }

        public string SsoID { get; set; }
        public int RoleId { get; set; }
        public string HashCode { get; set; }
        public string MergeHashCode { get; set; }
        public DateTime? LockTimeEnd { get; set; }
        public int? PasswordIncorrectCount { get; set; }

        [Display(Name = "اجبار به تغییر رمز عبور")]
        public bool ForceChangePassword { get; set; }

        public bool IsDeleted { get; set; }
        public bool? IsTwoFactorLogin { get; set; }
        public DateTime? LastSuccessLoginDateTime { get; set; }
        public DateTime? LastFaildLoginDateTime { get; set; }
        public int? LastFaildLoginCount { get; set; }
        public DateTime? CurrentSuccessLoginDateTime { get; set; }
        public List<UserBranch> UserBranches { get; set; }
        public List<UserCostCenter> UserCostCenters { get; set; }
        public string AvatarFileName { get; set; }
        public string SignatureFileName { get; set; }
        public string PersonnelCode { get; set; }
        public string UserPosition { get; set; }
        public Guid Id { get; set; }

        public string GetHashCode()
        {
            return string.Join("", GetEqualityComponents().Select(x => x != null ? x.ToString() : ""));
        }

        protected IEnumerable<object> GetEqualityComponents()
        {
            UserBranches = UserBranches ?? new List<UserBranch>();
            UserCostCenters = UserCostCenters ?? new List<UserCostCenter>();
            yield return UserId;
            yield return FullName;
            yield return UserName;
            yield return LoginFailedCount;
            yield return LastFaildLoginCount;
            yield return LastFaildLoginDateTime == null ? "" : LastFaildLoginDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            yield return LastSuccessLoginDateTime == null ? "" : LastSuccessLoginDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            yield return CurrentSuccessLoginDateTime == null ? "" : CurrentSuccessLoginDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            yield return Password;
            yield return RoleId;
            yield return IsActive;
            yield return Islock;
            yield return IsDeleted;
            yield return AccessFailedCount;
            yield return IsTwoFactorLogin;
            yield return NationalCode;
            yield return Email;
            yield return SsoID;
            yield return ActivationCode;
            yield return ForceChangePassword;
            yield return string.Join(",", UserBranches.Select(x => x.BranchId));
            yield return string.Join(",", UserCostCenters.Select(x => x.CostCenterId));
        }
    }
}
