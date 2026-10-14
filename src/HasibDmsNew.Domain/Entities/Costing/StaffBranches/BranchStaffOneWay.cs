using HasibDmsNew.Domain.Enums.Commons.Branchs;

namespace HasibDmsNew.Domain.Entities.Costing.StaffBranches
{
    public class BranchStaffOneWay
    {
        public int BranchStaffId { get; set; }
        public int BranchId { get; set; }
        public BranchOperationType Type { get; set; }
        public int PeriodId { get; set; }
        public decimal Price { get; set; }
    }
}
