using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Accounts;
using HasibDmsNew.Domain.Entities.Commons.Activities;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Budgets.Operation
{
    [Table("BudgetCostDetails")]
    public class BudgetCostDetail
    {
        [Key]
        public long Id { get; set; }

        public long ProductBudgetId { get; set; }
        public long? ProductStepBudgetId { get; set; }
        public int CostId { get; set; }
        public int? ActivityId { get; set; }
        public int CostType { get; set; }

        [MaxLength(512)]
        public string CostPath { get; set; }

        [MaxLength(15)]
        public string CostCode { get; set; }

        public decimal Count { get; set; }
        public decimal UnitRate { get; set; }
        public decimal TotalCost { get; set; }
        public decimal InflationRate { get; set; }
        public decimal CostWithInflation { get; set; }

        public int PeriodId { get; set; }
        public bool IsDirectCost { get; set; }
        public bool IsActivityCost { get; set; }
        public DateTime CreatedOn { get; set; }

        [ForeignKey("ProductBudgetId")]
        public virtual ProductBudget ProductBudget { get; set; }

        [ForeignKey("ProductStepBudgetId")]
        public virtual ProductStepBudget ProductStepBudget { get; set; }

        [ForeignKey("CostId")]
        public virtual Cost Cost { get; set; }

        [ForeignKey("ActivityId")]
        public virtual Activity Activity { get; set; }

        [ForeignKey("PeriodId")]
        public virtual Period Period { get; set; }
    }
}
