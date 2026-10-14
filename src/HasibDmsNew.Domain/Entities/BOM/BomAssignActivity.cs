namespace HasibDmsNew.Domain.Entities.BOM
{
    public class BomAssignActivity
    {
        public int Id { get; set; }
        public int BomInProductStepId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public int ActivityId { get; set; }
    }
}
