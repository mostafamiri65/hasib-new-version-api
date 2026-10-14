using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    [Table("ActivityItemCosts")]
    public class ActivityItemCost
    {
        public int Id { get; set; }
        public int ActivityItemId { get; set; }
        public int CostId { get; set; }
        public int CostCenterId { get; set; }
        public int MainCostCenterId { get; set; }
        public int ActivityAccountStructureId { get; set; }
    }
}
