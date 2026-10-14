using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    [Table("MainActivityCenterCostCenter")]
    public class MainActivityCenterCostCenter
    {
        [Key, Column(Order = 0)]
        public int MainActivityCenterId { get; set; }

        [Key, Column(Order = 1)]
        public int CostCenterId { get; set; }
    }
}
