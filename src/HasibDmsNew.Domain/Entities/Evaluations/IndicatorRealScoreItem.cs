namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorRealScoreItem
    {
        public int Id { get; set; }
        public int IndicatorRealScoreId { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string ReasonIds { get; set; }
    }
}
