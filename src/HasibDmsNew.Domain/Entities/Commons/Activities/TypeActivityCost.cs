namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class TypeActivityCost
    {
        public int Id { get; set; }
        public int TypeActivityId { get; set; }
        public int CostId { get; set; }
        public int CostCenterId { get; set; }
        public int MainCostCenterId { get; set; }
        public int ActivityAccountStructureId { get; set; }
    }
}
