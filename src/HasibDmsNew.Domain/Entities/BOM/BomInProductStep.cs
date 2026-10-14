using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Products;

namespace HasibDmsNew.Domain.Entities.BOM
{
    public class BomInProductStep
    {
        public int Id { get; set; }
        public int BomId { get; set; }
        public int ProductStepId { get; set; }
        public int ProcessActivityAccountStructureId { get; set; }

        [ForeignKey("BomId")]
        public BOM Bom { get; set; }

        [ForeignKey("ProductStepId")]
        public ProductStep ProductStep { get; set; }
    }
}
