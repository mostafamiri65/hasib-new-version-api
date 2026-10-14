using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.UserManagement.Roles;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowStepRole
    {
        public WorkFlowStepRole()
        {
            WorkFlowStepUsers = new List<WorkFlowStepUser>();
        }

        public int Id { get; set; }

        public WorkFlowStep WorkFlowStep { get; set; }
        public int WorkFlowStepId { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }

        public string StatusIds { get; set; }
        public ICollection<WorkFlowStepUser> WorkFlowStepUsers { get; set; }
    }
}
