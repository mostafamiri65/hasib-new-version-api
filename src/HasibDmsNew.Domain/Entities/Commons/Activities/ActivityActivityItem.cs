namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class ActivityActivityItem
    {
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
        public int ActivityItemId { get; set; }
        public int CostCenterId { get; set; }
    }
}
