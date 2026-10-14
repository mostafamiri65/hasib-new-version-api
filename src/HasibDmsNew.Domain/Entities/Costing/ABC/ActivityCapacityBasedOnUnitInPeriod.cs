using HasibDmsNew.Domain.Entities.Commons.Drivers;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Costing.ABC
{
    /// <summary>
    /// ظرفیت فعالیت بر اساس واحد(محرک) در دوره
    /// </summary>
    public class ActivityCapacityBasedOnUnitInPeriod
    {
        public int Id { get; set; }

        public decimal Capacity { get; set; }

        public int ActivityId { get; set; }
        public CostCenter Activity { get; set; }

        public int PeriodId { get; set; }
        public Period Period { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
