using HasibDmsNew.Domain.Entities.Commons.Activities;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Costing.ABC
{
    /// <summary>
    /// ظرفیت هزینه به فعالیت در هر دوره
    /// </summary>
    public class ActivityCostCapacityInPeriod
    {
        public int Id { get; set; }

        public decimal Capacity { get; set; }

        public int ActivityCostId { get; set; }
        public ActivityCost ActivityCost { get; set; }

        public int PeriodId { get; set; }
        public Period Period { get; set; }
    }
}
