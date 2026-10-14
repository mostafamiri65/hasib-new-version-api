namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorCriterionCostCenters
    {
        public int Id { get; set; }
        public int ProjectActivityId { get; set; }
        public int IndicatorId { get; set; }
        public int PeriodId { get; set; }
        public int CostCenterId { get; set; }
        public int BranchId { get; set; }
        public virtual IndicatorRealScore IndicatorRealScore { get; set; }
    }
}
