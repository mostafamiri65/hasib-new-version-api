using HasibDmsNew.Domain.Enums.Commons.Accounts;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    public class CostCategory
    {
        public int CostCategoryId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public CostCategoryType Type { get; set; }
        public bool IsLeaf { get; set; }
    }
}
