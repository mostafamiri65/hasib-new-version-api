namespace HasibDmsNew.Domain.Entities.Costing
{
    public class CapitalCostCategory
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
    }
}
