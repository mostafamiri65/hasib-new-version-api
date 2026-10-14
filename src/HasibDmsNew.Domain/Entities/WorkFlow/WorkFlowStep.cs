using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowStep
    {
        public WorkFlowStep()
        {
            WorkFlowStepRoles = new List<WorkFlowStepRole>();
            WorkFlowStepActivities = new List<WorkFlowStepActivity>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public WorkFlow WorkFlow { get; set; }
        public int WorkFlowId { get; set; }

        public WorkFlowForm WorkFlowForm { get; set; }
        public int? WorkFlowFormId { get; set; }

        public int Priority { get; set; }
        public byte Step { get; set; }
        public byte? Type { get; set; }
        public string NextBranches { get; set; }
        public string CostCenters { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<WorkFlowStepRole> WorkFlowStepRoles { get; set; }
        public ICollection<WorkFlowStepActivity> WorkFlowStepActivities { get; set; }
        public virtual ICollection<WorkFlowStepForm> WorkFlowStepForms { get; set; } = new List<WorkFlowStepForm>();
    }
}
