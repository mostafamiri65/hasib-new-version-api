namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrectionDocument
    {
        public int Id { get; set; }
        public int BudgetCorrectionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
    }
}
