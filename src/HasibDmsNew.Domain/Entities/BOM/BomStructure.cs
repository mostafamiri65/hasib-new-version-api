using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Branchs;
using HasibDmsNew.Domain.Entities.Commons.Years;
using HasibDmsNew.Domain.Entities.Costing;

namespace HasibDmsNew.Domain.Entities.BOM
{
    public class BomStructure
    {
        [Key]
        public int BomStructureId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public int BomInProductStepId { get; set; }
        public int BomType { get; set; }
        public int? CostCenterId { get; set; }
        public decimal AmountForOneUnit { get; set; }

        [ForeignKey(nameof(PeriodId))]
        public Period Period { get; set; }

        [ForeignKey(nameof(BranchId))]
        public Branch Branch { get; set; }

        [ForeignKey(nameof(BomInProductStepId))]
        public BomInProductStep BomInProductStep { get; set; }

        [ForeignKey(nameof(CostCenterId))]
        public CostCenter CostCenter { get; set; }
    }
}
