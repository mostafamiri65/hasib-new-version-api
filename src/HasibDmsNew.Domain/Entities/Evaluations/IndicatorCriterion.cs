namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorCriterion
    {
        public int IndicatorCriterionId { get; set; }
        public byte Type { get; set; }
        public int BranchId { get; set; }
        public int PeriodId { get; set; }
        public decimal? QuantitativeGoal { get; set; }
        public int IndicatorId { get; set; }
        public Indicator Indicator { get; set; }
        public int ProjectActivityId { get; set; }
        public decimal? LowRange { get; set; }
        public decimal? HighRange { get; set; }
        public decimal? CriterionPercent { get; set; }
    }
}
