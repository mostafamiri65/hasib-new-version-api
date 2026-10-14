using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlow
    {
        public WorkFlow()
        {
            WorkFlowSteps = new List<WorkFlowStep>();
            BudgetLineTypes = new List<WorkFlowBudgetLineType>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Branches { get; set; }
        public string Roles { get; set; }
        public string CostCenters { get; set; }
        public byte Type { get; set; }
        public byte Steps { get; set; }
        public string ProgramTypes { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public byte LockStatus { get; set; }
        public int? ProjectId { get; set; }
        public ICollection<WorkFlowStep> WorkFlowSteps { get; set; }
        public ICollection<WorkFlowBudgetLineType> BudgetLineTypes { get; set; }
    }
}
