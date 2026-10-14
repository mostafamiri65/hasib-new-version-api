using HasibDmsNew.Domain.Entities.Commons.StaffParts;

namespace HasibDmsNew.Domain.Entities.Costing.StaffCosts
{
    public class StaffPartTotalCostDetails
    {
        public int StaffPartTotalCostId { get; set; }
        public int StaffPartId { get; set; }

        public StaffPartTotalCost StaffPartTotalCost { get; set; }
        public StaffPart StaffPart { get; set; }
    }
}
