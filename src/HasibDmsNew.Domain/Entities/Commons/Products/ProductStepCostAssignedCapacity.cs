namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    public class ProductStepCostAssignedCapacity
    {
        public long ProductStepCostAssignedCapacityId { get; set; }
        public int CostInProductStepId { get; set; }
        public int CostTotalCapacityId { get; set; }
        public decimal AssignCapacity { get; set; }
    }
}
