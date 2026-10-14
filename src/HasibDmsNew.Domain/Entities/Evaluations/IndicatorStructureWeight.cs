namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorStructureWeight
    {
        public int IndicatorStructureWeightId { get; set; }
        public int ProjectActivityId { get; set; }
        public int PeriodId { get; set; }
        public int? GoalId { get; set; }
        public int? IndicatorStructureId { get; set; }
        public IndicatorStructure IndicatorStructure { get; set; }
        public int? IndicatorId { get; set; }
        public int? CostCenterId { get; set; }
        public decimal Weight { get; set; }
        public decimal RealPercent { get; set; }
        public byte Type { get; set; }
    }
}
