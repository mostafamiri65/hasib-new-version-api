namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetFundingDocument
    {
        public int Id { get; set; }
        public int BudgetFundingId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
    }
}
