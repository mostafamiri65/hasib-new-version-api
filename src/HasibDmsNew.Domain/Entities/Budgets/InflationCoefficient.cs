using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    [Table("InflationCoefficients")]
    public class InflationCoefficient
    {
        public int Id { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public int CostCategoryId { get; set; }
        public decimal InflationCoefficientValue { get; set; }
    }
}
