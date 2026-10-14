using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager
{
    [Table("CostManagerProfitActivity")]
    public class CostManagerProfitActivity
    {
        [Key, Column(Order = 0)]
        public int ActivityId { get; set; }

        [Key, Column(Order = 1)]
        public int CostManagerProfitId { get; set; }
    }
}
