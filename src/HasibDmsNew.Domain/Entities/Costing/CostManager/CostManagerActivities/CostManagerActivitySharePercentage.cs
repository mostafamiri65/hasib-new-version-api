using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager.CostManagerActivities
{
    [Table("CostManagerActivitySharePercentage")]
    public class CostManagerActivitySharePercentage
    {
        [Key]
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int MainCostCenterId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public bool IsDefualt { get; set; }
        public decimal Type1_Percentage { get; set; }
        public decimal Type2_Percentage { get; set; }
        public decimal Type3_Percentage { get; set; }
        public decimal Type4_Percentage { get; set; }
    }
}
