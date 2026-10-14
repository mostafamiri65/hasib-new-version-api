namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetSupplementDocument
    {
        public int Id { get; set; }
        public int BudgetSupplementId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
    }
}
