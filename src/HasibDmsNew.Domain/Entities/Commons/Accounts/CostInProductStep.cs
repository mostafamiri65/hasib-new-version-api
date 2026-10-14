using HasibDmsNew.Domain.Entities.Commons.Products;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    /// <summary>
    /// هزینه در مرحله
    /// </summary>
    public class CostInProductStep
    {
        public int Id { get; set; }

        public int MainCostCenterId { get; set; }

        public int CostId { get; set; }
        public Cost Cost { get; set; }

        public int ProductStepId { get; set; }
        public ProductStep ProductStep { get; set; }

        public int ProcessActivityAccountStructureid { get; set; }
    }
}
