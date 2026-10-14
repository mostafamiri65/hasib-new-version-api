using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Commons.StaffParts;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Costing.StaffCosts
{
    public class StaffPartTotalCost
    {
        public int StaffPartTotalCostId { get; set; }
        public int StaffPartId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }

        public decimal TotalCost { get; set; }
        public decimal TotalStaffPartCost { get; set; }
        public decimal CalculationCost { get; set; }

        public StaffPart StaffPart { get; set; }
        public Period Period { get; set; }
        public FiscalYear FiscalYear { get; set; }
        public ICollection<StaffPartTotalCostDetails> StaffPartTotalCostDetails { get; set; }
        public ICollection<StaffCostDetails> StaffCostDetails { get; set; }
    }
}
