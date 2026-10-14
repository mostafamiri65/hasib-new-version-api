namespace HasibDmsNew.Domain.Entities.Costing
{
    public class CostCenterCost
    {
        public int MainId { get; set; }
        public CostCenterCostMain CostCenterCostMain { get; set; }
        public int CostCenterId { get; set; }
        public int MainCostCenterId { get; set; }
        public int CostId { get; set; }
    }
}
