namespace HasibDmsNew.Domain.Entities.Costing.StaffBranches
{
    public class StaffBranchPriority
    {
        public int StaffBranchPriorityId { get; set; }
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public decimal PriorityValue { get; set; }
    }
}
