using HasibDmsNew.Domain.Entities.Commons.Drivers;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Costing.ABC
{
    /// <summary>
    /// ظرفیت محرک در هر دوره
    /// </summary>
    public class UnitCapacityInPeriod
    {
        public int Id { get; set; }

        public decimal TotalCapacity { get; set; }
        public decimal AssignedCapacity { get; set; }

        public int PeriodId { get; set; }
        public Period Period { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
