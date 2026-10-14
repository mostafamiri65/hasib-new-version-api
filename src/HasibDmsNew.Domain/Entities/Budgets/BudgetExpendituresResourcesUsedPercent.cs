namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetExpendituresResourcesUsedPercent
    {
        public int BudgetExpendituresResourcesId { get; set; }
        public int RelatedBudgetExpendituresResourcesId { get; set; }
        public decimal Percent { get; set; }
    }
}
