namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    public class PivotColumnGroup
    {
        public int Id { get; set; }
        public int PivotTableId { get; set; }
        public string Title { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
        public string Color { get; set; }
    }
}
