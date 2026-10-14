using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Costing.StaffCosts;

namespace HasibDmsNew.Domain.Entities.Commons.StaffParts
{
    /// <summary>
    /// دوایر برای هزینه های پشتیبانی
    /// </summary>
    public class StaffPart
    {
        public int StaffPartId { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<StaffPartPriority> StaffPartPriorities { get; set; }
        public ICollection<StaffPartTotalCost> StaffPartTotalCosts { get; set; }
        public ICollection<StaffPartTotalCostDetails> StaffPartTotalCostDetails { get; set; }
    }
}
