using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager
{
    [Table("CostManagerProfitProduct")]
    public class CostManagerProfitProduct
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }

        [Key, Column(Order = 1)]
        public int CostManagerProfitId { get; set; }
    }
}
