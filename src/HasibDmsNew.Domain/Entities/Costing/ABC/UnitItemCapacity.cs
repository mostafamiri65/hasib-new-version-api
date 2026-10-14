using HasibDmsNew.Domain.Entities.Commons.Branchs;
using HasibDmsNew.Domain.Entities.Commons.Drivers;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Costing.ABC
{
    public class UnitItemCapacity
    {
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public decimal Capacity { get; set; }
    }
}
