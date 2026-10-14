namespace HasibDmsNew.Domain.Entities.Costing.StaffBranches
{
    public class BranchAllocationBaseAssign
    {
        public int BranchAllocationBaseAssignId { get; set; }
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int AllocationBaseId { get; set; }
        public decimal AllocationBaseValue { get; set; }
    }
}
