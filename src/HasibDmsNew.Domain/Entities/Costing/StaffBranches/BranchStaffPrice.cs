namespace HasibDmsNew.Domain.Entities.Costing.StaffBranches
{
    public class BranchStaffPrice
    {
        public int BranchId { get; set; }
        public int PeriodId { get; set; }
        public decimal StaffPrice { get; set; }
        public decimal OtherPrice { get; set; }
        public decimal CalculatePrice { get; set; }
    }
}
