using System.Collections.Generic;
using System.Linq;
using HasibDmsNew.Domain.Entities.UserManagement.Roles;

namespace HasibDmsNew.Domain.Entities.UserManagement.Users
{
    public class UserRole
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public new string GetHashCode()
        {
            return string.Join("", GetEqualityComponents().Select(x => x != null ? x.ToString() : ""));
        }

        protected IEnumerable<object> GetEqualityComponents()
        {
            yield return UserId;
            yield return RoleId;
        }
    }
}
