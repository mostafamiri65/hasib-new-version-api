namespace HasibDmsNew.Domain.Entities.Costing.StaffBranches
{
    public class ProductStepPriceOfStaffBranch
    {
        public int ProductStepId { get; set; }
        public int BranchId { get; set; }
        public int PeriodId { get; set; }
        public int StaffBranchId { get; set; }
        public decimal Price { get; set; }
    }
}
