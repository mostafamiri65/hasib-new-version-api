using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Enums.Budgets;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetExpendituresResources
    {
        public int BudgetExpendituresResourcesId { get; set; }
        public int BranchId { get; set; }
        public int? CostCenterId { get; set; }
        public int? GoalId { get; set; }
        public int? BenchMarkId { get; set; }
        public int? CapitalCostId { get; set; }
        public int FiscalYearId { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public BudgetExpenditureResourceCategory Type { get; set; }
        public int BudgetExpenditureResourceTypeId { get; set; }
        public decimal OfferedAmount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public decimal IntendedAmount { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal LastYearsApprovedAmount { get; set; }
        public List<BudgetExpendituresResourcesUsedPercent> BudgetExpendituresResourcesUsedPercents { get; set; }
    }
}
