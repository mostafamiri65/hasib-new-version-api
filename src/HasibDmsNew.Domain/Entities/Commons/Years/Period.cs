using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Commons.Accounts;
using HasibDmsNew.Domain.Entities.Costing.ABC;
using HasibDmsNew.Domain.Entities.Costing.StaffCosts;

namespace HasibDmsNew.Domain.Entities.Commons.Years
{
    /// <summary>
    /// دوره در سال مالی
    /// </summary>
    public class Period
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int FiscalYearId { get; set; }
        public FiscalYear FiscalYear { get; set; }
        public IEnumerable<StaffPartTotalCost> StaffPartTotalCosts { get; set; }
        public ICollection<CostRateInPeriod> CostRateInPeriods { get; set; }
        public ICollection<UnitCapacity> UnitCapacites { get; set; }
        public ICollection<UnitItemCapacity> UnitItemCapacites { get; set; }
        public ICollection<UnitItemActivityCapacity> UnitItemActivityCapacites { get; set; }
    }
}
