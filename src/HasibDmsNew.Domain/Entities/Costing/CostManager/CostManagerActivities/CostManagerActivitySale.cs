using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager.CostManagerActivities
{
    [Table("CostManagerActivitySale")]
    public class CostManagerActivitySale
    {
        [Key]
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int MainCostCenterId { get; set; }
        public int BranchId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
