using HasibDmsNew.Domain.Entities.Commons.Branchs;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowNextBranch
    {
        public int Id { get; set; }

        public WorkFlowStep WorkFlowStep { get; set; }
        public int WorkFlowStepId { get; set; }

        public Branch Branch { get; set; }
        public int BranchId { get; set; }

        public int NextBranchId { get; set; }
    }
}
