namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetLineCostCenter
    {
        public int BudgetLineId { get; set; }
        public BudgetLine BudgetLine { get; set; }
        public int CostCenterId { get; set; }
    }
}
