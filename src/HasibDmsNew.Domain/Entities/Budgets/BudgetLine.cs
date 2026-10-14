using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetLine
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public int TreeTitleId { get; set; }
        public int? CostId { get; set; }
        public bool IsLeaf { get; set; }
        public byte Type { get; set; }
        public byte ExtraType { get; set; }
        public string Path { get; set; }
        public List<BudgetLineCostCenter> CostCenters { get; set; }
    }
}
