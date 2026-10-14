using HasibDmsNew.Domain.Entities.Commons.Products;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    /// <summary>
    /// فعالیت در مرحله
    /// </summary>
    public class ActivityInProductStep
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public int ProductStepId { get; set; }
        public ProductStep ProductStep { get; set; }

        public int CostCenterId { get; set; }
        public int ProcessActivityAccountStructureid { get; set; }
    }
}
