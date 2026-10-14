using System.Collections.Generic;
using HasibDmsNew.Domain.Enums.Costing.StaffCosts;

namespace HasibDmsNew.Domain.Entities.Costing.StaffCosts
{
    public class StaffCost
    {
        public long StaffCostId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int StaffPartId { get; set; }

        /// <summary>
        /// مشخص می‌کند دایره یا فرایند است
        /// </summary>
        public StaffCostType Type { get; set; }

        public int EntityId { get; set; }
        public decimal Value { get; set; }
        public byte IsAccess { get; set; }

        public ICollection<StaffCostDetails> StaffCostDetails { get; set; }
    }
}
