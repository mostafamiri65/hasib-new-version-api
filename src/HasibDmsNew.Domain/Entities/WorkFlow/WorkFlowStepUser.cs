using HasibDmsNew.Domain.Entities.Commons.Branchs;
using HasibDmsNew.Domain.Entities.UserManagement.Users;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowStepUser
    {
        public int Id { get; set; }

        public WorkFlowStepRole WorkFlowStepRole { get; set; }
        public int WorkFlowStepRoleId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}
