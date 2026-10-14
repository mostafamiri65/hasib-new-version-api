using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager.CostManagerActivities
{
    [Table("CostManagerActivityCostSharePercentage")]
    public class CostManagerActivityCostSharePercentage
    {
        [Key]
        [Column(Order = 0)]
        public int CostId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int SharePercentageId { get; set; }

        public decimal Percentage { get; set; }
    }
}
