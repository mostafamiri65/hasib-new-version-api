namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorRealScore
    {
        public int IndicatorCriterionCostCenterId { get; set; }
        public decimal? UserRealScore { get; set; }
        public decimal? RealScore { get; set; }
        public int? IndicatorCriterionId { get; set; }
        public decimal CriterionPercent { get; set; }
        public int? WorkFlowStepActivityId { get; set; }
        public virtual IndicatorCriterionCostCenters IndicatorCriterionCostCenter { get; set; }
        public byte WorkFlowStatus { get; set; }
    }
}
