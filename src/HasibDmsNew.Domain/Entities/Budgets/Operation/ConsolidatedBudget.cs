using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Branchs;
using HasibDmsNew.Domain.Entities.Commons.Years;
using HasibDmsNew.Domain.Entities.Strategics.Goals;

namespace HasibDmsNew.Domain.Entities.Budgets.Operation
{
    [Table("ConsolidatedBudgets")]
    public class ConsolidatedBudget
    {
        [Key]
        public long Id { get; set; }

        public int GoalId { get; set; }
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal TotalProductsCount { get; set; }
        public decimal TotalDirectMaterialCost { get; set; }
        public decimal TotalDirectWageCost { get; set; }
        public decimal TotalActivityCost { get; set; }
        public decimal TotalSupportCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalCostWithInflation { get; set; }
        public decimal AverageInflationRate { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        [ForeignKey("GoalId")]
        public virtual Goal Goal { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("FiscalYearId")]
        public virtual FiscalYear FiscalYear { get; set; }

        [ForeignKey("PeriodId")]
        public virtual Period Period { get; set; }
    }
}
