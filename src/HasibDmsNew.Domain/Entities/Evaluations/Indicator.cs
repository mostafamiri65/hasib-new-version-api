namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class Indicator
    {
        public int IndicatorId { get; set; }
        public int IndicatorStructureId { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public int MainIndicatorId { get; set; }
        public string Code { get; set; }
        public int IndicatorTypeId { get; set; }
        public int MeasurementUnitId { get; set; }
        public int Priority { get; set; }
        public byte NatureType { get; set; }
    }
}
