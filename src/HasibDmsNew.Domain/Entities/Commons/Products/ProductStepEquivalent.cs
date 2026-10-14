using HasibDmsNew.Domain.Enums.Commons.Products;

namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    public class ProductStepEquivalent
    {
        public int ProductStepId { get; set; }
        public int PeriodId { get; set; }
        public EquivalentUnitType Type { get; set; }
        public decimal DirectMaterial { get; set; }
        public decimal DirectLabor { get; set; }
        public decimal InDirectCost { get; set; }
        public decimal EquivalentDirectMaterial { get; set; }
        public decimal EquivalentDirectLabor { get; set; }
        public decimal EquivalentInDirectCost { get; set; }
    }
}
