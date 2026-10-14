namespace HasibDmsNew.Domain.Entities.Costing
{
    public class CostCenterWithParent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int TreeTitleId { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public string RootPath { get; set; }
        public string ParentRootPath { get; set; }
        public byte Type { get; set; }
        public int Priority { get; set; }
    }
}
