using System;

namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorCriterionSetting
    {
        public int Id { get; set; }
        public int ProjectActivityId { get; set; }
        public int IndicatorId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
