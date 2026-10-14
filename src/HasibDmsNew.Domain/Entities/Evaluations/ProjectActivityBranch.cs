using HasibDmsNew.Domain.Entities.Commons.Branchs;

namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class ProjectActivityBranch
    {
        public int ProjectActivityId { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
