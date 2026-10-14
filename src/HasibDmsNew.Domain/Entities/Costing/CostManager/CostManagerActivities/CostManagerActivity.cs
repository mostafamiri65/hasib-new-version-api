using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager.CostManagerActivities
{
    [Table("CostManagerActivity")]
    public class CostManagerActivity
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public int MainCostCenterId { get; set; }
    }
}
