using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager
{
    [Table("CostManagerProductSharePercentage")]
    public class CostManagerProductSharePercentage
    {
        public int Id { get; set; }
        public int PeriodId { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public string Title { get; set; }
        public bool IsDefualt { get; set; }
        public decimal Type1_Percentage { get; set; }
        public decimal Type2_Percentage { get; set; }
        public decimal Type3_Percentage { get; set; }
        public decimal Type4_Percentage { get; set; }
    }
}
