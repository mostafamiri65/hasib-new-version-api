using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Commons.StaffParts
{
    public class StaffPartPriority
    {
        public int StaffPartPriorityId { get; set; }
        public int Priority { get; set; }
        public int StaffPartId { get; set; }
        public int PeriodId { get; set; }

        public Period Period { get; set; }
        public StaffPart StaffPart { get; set; }
    }
}
