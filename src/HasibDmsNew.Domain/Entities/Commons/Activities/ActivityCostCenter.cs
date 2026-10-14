namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class ActivityCostCenter
    {
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
        public int CostCenterId { get; set; }
    }
}
