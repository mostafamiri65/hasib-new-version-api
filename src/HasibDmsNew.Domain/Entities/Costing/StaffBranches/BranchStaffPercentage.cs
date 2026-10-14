namespace HasibDmsNew.Domain.Entities.Costing.StaffBranches
{
    public class BranchStaffPercentage
    {
        public int BranchStaffPercentageId { get; set; }
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal StaffPercent { get; set; }
        public decimal OperationPercent { get; set; }
    }
}
