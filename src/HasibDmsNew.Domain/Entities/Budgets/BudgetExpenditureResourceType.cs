using HasibDmsNew.Domain.Enums.Budgets;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetExpenditureResourceType
    {
        public int BudgetExpenditureResourceTypeId { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public BudgetExpenditureResourceCategory Type { get; set; }
        public bool IsLeaf { get; set; }
        public string Code { get; set; }
    }
}
