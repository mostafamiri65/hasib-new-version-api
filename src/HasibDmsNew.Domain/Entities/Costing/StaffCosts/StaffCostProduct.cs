using HasibDmsNew.Domain.Enums.Costing.StaffCosts;

namespace HasibDmsNew.Domain.Entities.Costing.StaffCosts
{
    public class StaffCostProduct
    {
        public long StaffCostProductId { get; set; }
        public int ProductId { get; set; }
        public int ProcessId { get; set; }
        public int PeriodId { get; set; }
        public int? ParentId { get; set; }
        public StaffCostType Type { get; set; }
        public decimal CostPrice { get; set; }
    }
}
