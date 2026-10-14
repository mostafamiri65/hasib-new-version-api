using HasibDmsNew.Domain.Enums.Commons.Settings;

namespace HasibDmsNew.Domain.Entities.Commons.Years
{
    public class BranchComputionType
    {
        public int BranchComputionTypeId { get; set; }
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public CostComputionType CostComputionType { get; set; }
        public StaffComputionType StaffComputionType { get; set; }
        public ActivityStructureComputationType? ActivityStructureComputationType { get; set; }
        public CostAssignComputationType CostAssignComputationType { get; set; }
    }
}
