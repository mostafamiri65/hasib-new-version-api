using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Branchs;
using HasibDmsNew.Domain.Entities.Commons.Products;
using HasibDmsNew.Domain.Entities.Commons.Years;
using HasibDmsNew.Domain.Entities.Strategics.Goals;

namespace HasibDmsNew.Domain.Entities.Budgets.Operation
{
    [Table("ProductStepBudgets")]
    public class ProductStepBudget
    {
        [Key]
        public long Id { get; set; }

        public long ProductBudgetId { get; set; }
        public int ProductStepId { get; set; }
        public int ProductId { get; set; }
        public int GoalId { get; set; }
        public int BranchId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal StepCount { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal DirectMaterialCost { get; set; }
        public decimal DirectWageCost { get; set; }
        public decimal ActivityCost { get; set; }
        public decimal SupportCost { get; set; }
        public decimal InflationRate { get; set; }
        public decimal CostWithInflation { get; set; }

        public DateTime CreatedOn { get; set; }

        [ForeignKey("ProductBudgetId")]
        public virtual ProductBudget ProductBudget { get; set; }

        [ForeignKey("ProductStepId")]
        public virtual ProductStep ProductStep { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("GoalId")]
        public virtual Goal Goal { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("FiscalYearId")]
        public virtual FiscalYear FiscalYear { get; set; }

        [ForeignKey("PeriodId")]
        public virtual Period Period { get; set; }

        public virtual ICollection<BudgetCostDetail> BudgetCostDetails { get; set; }
    }
}
