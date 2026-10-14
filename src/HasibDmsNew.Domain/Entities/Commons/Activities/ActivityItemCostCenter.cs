namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class ActivityItemCostCenter
    {
        public int ActivityItemId { get; set; }
        public virtual ActivityItem ActivityItem { get; set; }
        public int CostCenterId { get; set; }
    }
}
