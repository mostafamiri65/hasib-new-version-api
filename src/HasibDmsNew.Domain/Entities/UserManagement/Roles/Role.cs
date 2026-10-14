using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HasibDmsNew.Domain.Entities.UserManagement.Roles
{
    [DisplayName("نقش")]
    public class Role
    {
        public int RoleId { get; set; }
        public string Title { get; set; }
        public string PersianTitle { get; set; }
        public string Permission { get; set; }
        public bool IsDeleted { get; set; }
        public string HashCode { get; set; }
        public string MergeHashCode { get; set; }

        public new string GetHashCode()
        {
            return string.Join("", GetEqualityComponents().Select(x => x != null ? x.ToString() : ""));
        }

        protected IEnumerable<object> GetEqualityComponents()
        {
            yield return RoleId;
            yield return Title;
            yield return PersianTitle;
            yield return Permission;
            yield return IsDeleted;
        }
    }
}
