using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Costing;

namespace HasibDmsNew.Domain.Entities.BOM
{
    public class BOMMainCostCenter
    {
        public int BOMId { get; set; }
        public int MainCostCenterId { get; set; }

        [ForeignKey(nameof(BOMId))]
        public BOM BOM { get; set; }

        [ForeignKey(nameof(MainCostCenterId))]
        public MainCostCenter MainCostCenter { get; set; }
    }
}
