using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager
{
    [Table("CostManagerProduct")]
    public class CostManagerProduct
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public int PeriodId { get; set; }
        public decimal? Profit { get; set; }
        public decimal? TargetPrice { get; set; }
    }
}
