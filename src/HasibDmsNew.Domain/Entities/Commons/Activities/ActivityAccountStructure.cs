namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class ActivityAccountStructure
    {
        public int ActivityAccountStructureId { get; set; }
        public string Title { get; set; }
        public int ActivityTreeTitleId { get; set; }
        public int CostCenterCostMainId { get; set; }
        public int AccountTreeTitleId { get; set; }
        public int CostCenterTreeTitleId { get; set; }
        public int ActivityType { get; set; }
    }
}
